using ClosedXML.Excel;
using FileSharingApp.Areas.Admin.Models;
using FileSharingApp.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Areas.Admin.Controllers
{
    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;
        private readonly IXLWorkbook workbook;

        public UserController(IUserService userService, IXLWorkbook workbook)
        {
            this.userService = userService;
            this.workbook = workbook;
        }
        public async Task<IActionResult> Index()
        {
            var result = await userService.GetAll().ToListAsync();
            return View(result);
        }
        public async Task<IActionResult> Blocked()
        {
            var result =await userService.GetBlockedUser().ToListAsync(); 
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Search(InputSearch model)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.Search(model.term).ToListAsync();
                return View("Index",result);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Blocked(string UserId)
        {
            if (!string.IsNullOrEmpty(UserId))
            {
                var result = await userService.ToggleBlockedUserAsync(UserId);
                if (result.Success)
                {
                    TempData["Success"] = result.Message;
                }
                else
                {
                    TempData["Error"] = result.Message;
                }
                return RedirectToAction("Index");
            }
            TempData["Error"] = "User Id is Not Found";
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> UserCounts()
        {
            var result =await userService.UserRegisterationCountAsync();
            return Json(result);
        }

        public async Task<IActionResult> totalUserCount()
        {
            var totalUserCounts = await userService.UserRegisterationCountAsync();
            var month = DateTime.Today.Month;
            var monthUserCounts = await userService.UserRegisterationCountAsync(month);
            return Json(new {total=totalUserCounts,month=monthUserCounts });
        }


        public async Task<IActionResult> ExportToExcel()
        {
            var ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var FileName = "Users.xlsx";

            var result = await userService.GetAll().ToListAsync();

            var Worksheet = workbook.Worksheets.Add("All Users");
            Worksheet.Cell(1, 1).Value = "First Name";
            Worksheet.Cell(1, 2).Value = "Last Name";
            Worksheet.Cell(1, 3).Value = "Email";
            Worksheet.Cell(1, 4).Value = "Created Date";

            for (int i = 1; i <result.Count ; i++)
            {
                int row = i + 1;
                Worksheet.Cell(row, 1).Value = result[i-1].FirstName;
                Worksheet.Cell(row, 2).Value =  result[i - 1].LastName;
                Worksheet.Cell(row, 3).Value = result[i - 1].Email;
                Worksheet.Cell(row, 4).Value = result[i - 1].CreatedDate;

            }

            using (var ms =new MemoryStream())
            {
                workbook.SaveAs(ms);
                return File(ms.ToArray(),ContentType,FileName);
            }
           
        }



    }
}
