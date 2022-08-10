using FileSharingApp.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rotativa.AspNetCore;

namespace FileSharingApp.Areas.Admin.Controllers
{
    public class ReportsController : BaseAdminController
    {
        private readonly IUserService userService;

        public ReportsController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Users()
        {
            var model = userService.GetAll().ToList();

            return new ViewAsPdf(model);
        }
    }
}
