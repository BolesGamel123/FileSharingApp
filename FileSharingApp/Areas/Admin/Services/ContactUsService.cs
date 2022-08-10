using AutoMapper;
using AutoMapper.QueryableExtensions;
using FileSharingApp.Areas.Admin.Models;
using FileSharingApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Areas.Admin.Services
{
    public class ContactUsService : IContactUsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        public ContactUsService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task ChangeStatusAsync(int Id, bool Status)
        {
            var SelectItem = await context.Contacts.FindAsync(Id);
            if (SelectItem !=null)
            {
                SelectItem.Status = Status;
                context.Update(SelectItem);
                await context.SaveChangesAsync();
            }
        }

        public IQueryable<ContactUsViewModel> GetAll()
        {
            var Result = context.Contacts
             .ProjectTo<ContactUsViewModel>(mapper.ConfigurationProvider);
            return Result;
        }
    }
}
