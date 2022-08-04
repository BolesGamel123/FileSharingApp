using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using FileSharingApp.Models;
using FileSharingApp.Data;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using FileSharingApp.Services;

namespace FileSharingApp.Controllers
{
    [Authorize]
    public class UploadsController : Controller
    {
        private readonly IUploadService uploadService;
        private readonly IWebHostEnvironment env;
        public UploadsController(IUploadService uploadService, IWebHostEnvironment env)
        {
            this.uploadService = uploadService;
            this.env = env;
        }
        private string UserId
        {
            get
            {
                return User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
        }
        public IActionResult Index()
        {

            var result = uploadService.Getby(UserId);
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(InputFile model)
        {
            if (ModelState.IsValid)
            {
                var NewName = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(model.File.FileName);
                var FileName = string.Concat(NewName, extension);
                var root = env.WebRootPath;
                var path = Path.Combine(root, "Uploads", FileName);
                using (var file =System.IO.File.Create(path))
                {
                  await  model.File.CopyToAsync(file);
                }

               await uploadService.CreateAsync(new InputUpload
               {
                   OriginFileName=model.File.FileName,
               FileName=FileName,
               ContentType=model.File.ContentType,
               Size=model.File.Length,
               UserId=UserId,
              
               
               });
                
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var selectimagedelete = await uploadService.FindAsync(id, UserId);

            if(selectimagedelete ==null)
            {
                return NotFound();
            }

            return View(selectimagedelete);
        }


        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmation(string id)
        {
            var selectimagedelete = await uploadService.FindAsync(id, UserId);

            if (selectimagedelete == null)
            {
                return NotFound();
            }

            await uploadService.DeleteAsync(id,UserId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Results(string Term,int RequiredPage=1)
        {
            var result = uploadService.Search(Term);
            var model = await GetPageData(result, RequiredPage);

            return View(model);
        }


  
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Browse(int RequiredPage=1)
        {
            var result = uploadService.GetAll();
            var model=await GetPageData(result,RequiredPage);
            return View(model);
        }
        private async Task<List<UploadViewModel>> GetPageData(IQueryable<UploadViewModel> result, int RequiredPage = 1)
        {
            const int PageSize = 10;
            decimal RowsCount = await uploadService.GetUploadCount();
            var PageCount = Math.Ceiling(RowsCount / PageSize);
            RequiredPage = RequiredPage <= 0 ? 1 : RequiredPage;
            if (RequiredPage > PageCount)
            {
                RequiredPage = 1;
            }
            int SkipCount = (RequiredPage - 1) * PageSize;


            var PageData = await result.Skip(SkipCount).Take(PageSize).ToListAsync();
            ViewBag.CurrentPage = RequiredPage;
            ViewBag.PageCount = PageCount;
            return PageData;
        }


        [HttpGet]
        public async Task<IActionResult> Download(string id)
        {
            var selectedFile = await uploadService.FindAsync(id);
            if (selectedFile == null)
            {
                return NotFound();
            }
            await uploadService.IncreamentDownloadCount(id);
            
            Response.Headers.Add("Expires", DateTime.Now.AddDays(-3).ToLongDateString());
            Response.Headers.Add("Cache-Control", "no-cache");
            var Path = "~/Uploads/" + selectedFile.FileName;
            return File(Path,selectedFile.ContentType,selectedFile.OriginFileName);
        }
    }
}
