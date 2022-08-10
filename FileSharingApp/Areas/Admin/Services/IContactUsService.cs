using FileSharingApp.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Areas.Admin.Services
{
     public interface IContactUsService
    {
        IQueryable<ContactUsViewModel> GetAll();
        Task ChangeStatusAsync(int Id, bool Status);
    }
}
