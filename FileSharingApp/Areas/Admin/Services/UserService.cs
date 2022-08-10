using AutoMapper;
using AutoMapper.QueryableExtensions;
using FileSharingApp.Areas.Admin.Models;
using FileSharingApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Areas.Admin.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserService(ApplicationDbContext context,IMapper mapper
            ,UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<OperationResult> ToggleBlockedUserAsync(string UserId)
        {
            var UserExisted = await context.Users.FindAsync(UserId);
            if (UserExisted == null)
            {
                return OperationResult.NotFound();
            }
            UserExisted.IsBlocked = !UserExisted.IsBlocked;
            context.Update(UserExisted);
           await context.SaveChangesAsync();
            return OperationResult.Succeeded();
        }

        public IQueryable<AdminUserViewModel> GetAll()
        {
            var Result = context.Users
                .OrderByDescending(u=>u.CreatedDate)
                 .ProjectTo<AdminUserViewModel>(mapper.ConfigurationProvider);
            return Result;
        }

        public IQueryable<AdminUserViewModel> GetBlockedUser()
        {
            var Result = context.Users.Where(u=>u.IsBlocked)
                .OrderByDescending(u => u.CreatedDate)
                  .ProjectTo<AdminUserViewModel>(mapper.ConfigurationProvider);
            return Result;
        }

        public IQueryable<AdminUserViewModel> Search(string term)
        {
            var Result = context.Users.
                Where(u=>u.Email.Contains(term) ||
                u.FirstName.Contains(term) || u.LastName.Contains(term)
                ||(u.FirstName+" "+u.LastName).Contains(term))
                .OrderByDescending(u => u.CreatedDate)
                 .ProjectTo<AdminUserViewModel>(mapper.ConfigurationProvider);
            return Result;
        }

        public async Task<int> UserRegisterationCountAsync()
        {
            var Count = await context.Users.CountAsync();
            return Count;
        }

        public async Task<int> UserRegisterationCountAsync(int month)
        {
            var year = DateTime.Today.Year;
            var Count = await context.Users
                .CountAsync(u=>u.CreatedDate.Month==month &&u.CreatedDate.Year==year);
            return Count;
        }

        public async Task InitializeAsync()
        {
            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            }
            var EmailAdmin = "g@g.com";
            if (await userManager.FindByEmailAsync(EmailAdmin) ==null)
            {
                var user = new ApplicationUser { 
                Email=EmailAdmin,
                UserName=EmailAdmin,
                PhoneNumber="01204047837",
                EmailConfirmed=true,
                PhoneNumberConfirmed=true
                };

                await userManager.CreateAsync(user, "G_g123456789");
                await userManager.AddToRoleAsync(user, UserRoles.Admin);
            }
        }
    }
}
