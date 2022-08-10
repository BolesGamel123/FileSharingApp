using FileSharingApp.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Areas.Admin.Services
{
     public interface IUserService
    {
        IQueryable<AdminUserViewModel> GetAll();

        IQueryable<AdminUserViewModel> GetBlockedUser();
        IQueryable<AdminUserViewModel> Search(string term);

        Task<OperationResult> ToggleBlockedUserAsync(string UserId);

        Task<int> UserRegisterationCountAsync();

        Task<int> UserRegisterationCountAsync(int month);

        Task InitializeAsync();
    }
}
