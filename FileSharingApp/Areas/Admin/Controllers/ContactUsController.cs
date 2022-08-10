using FileSharingApp.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Areas.Admin.Controllers
{
    public class ContactUsController : BaseAdminController
    {
        private readonly IContactUsService contactUsService;
     

        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;
            
        }
        public async Task<IActionResult> Index()
        {
            var result = await contactUsService.GetAll().ToListAsync();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeStatus(int id,bool Status)
        {
          await contactUsService.ChangeStatusAsync(id,Status);
            return RedirectToAction("Index");
        }
    }
}
