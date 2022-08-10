using FileSharingApp.Data;

using FileSharingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FileSharingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;
   

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context
            )
        {
            _logger = logger;
            this.context = context;
         
        }

        public IActionResult Index()
        {
            var heighestDownload = context.Uploads.OrderByDescending(u => u.DownloadCount).Select(u =>
         new UploadViewModel
         {
             Id = u.Id,
             FileName = u.FileName,
             OriginFileName = u.OriginFileName,
             ContentType = u.ContentType,
             Size = u.Size,
             UploadDate = u.UploadDate
         }
         ).Take(3);
            ViewBag.Popular = heighestDownload;
        

            return View();
        }

        public IActionResult Privacy()
        {
     
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public IActionResult Contact()
        {

            return View();
        }
        private string UserId
        {
            get
            {
                return User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(new Contact {
                Email=model.Email,
                Name=model.Name,
                Message=model.Message,
                Subject=model.Subject,
               UserId= UserId

                });
              await  context.SaveChangesAsync();
                TempData["Message"] = "Message has been sent Successfull !.";

              
                return RedirectToAction("Contact");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult About()
        {
           

            return View();
        }

        [HttpPost]
        public IActionResult About(ContactViewModel model)
        {

            return View();
        }

        [HttpGet]
        public IActionResult SetLang(string Lang,string ReturnUrl=null)
        {
            if (!string.IsNullOrEmpty(Lang))
            {
                Response.Cookies.Append(
                   CookieRequestCultureProvider.DefaultCookieName,
                   CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(Lang)),
                   new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
               );
            }

            if (!string.IsNullOrEmpty(ReturnUrl))
            {
                return LocalRedirect(ReturnUrl);
            }
            
            return RedirectToAction("Index");
        }
    }
}
