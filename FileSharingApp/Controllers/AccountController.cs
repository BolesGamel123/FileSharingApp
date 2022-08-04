using AutoMapper;
using FileSharingApp.Data;
using FileSharingApp.Models;
using FileSharingApp.Resources;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FileSharingApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMapper mapper;
        private readonly IStringLocalizer<SharedResource> stringLocalizer;

        public AccountController(SignInManager<ApplicationUser> signInManager,UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IStringLocalizer<SharedResource> stringLocalizer
          
            )
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.mapper = mapper;
            this.stringLocalizer = stringLocalizer;
        }
       

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Login(LoginViewModel model,string returnUrl)
        {
            if(ModelState.IsValid)
            {
               var result=await signInManager.PasswordSignInAsync(model.Email, model.Password, true, true);
                if(result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    return RedirectToAction("Create", "Uploads");
                }
                //else if(result.IsNotAllowed){
                //    TempData["Error"] = stringLocalizer["RequireConfirmedEmail"]?.Value;
                //}
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    Email = model.Email, UserName = model.Email,
                    FirstName=model.FirstName,LastName=model.LastName
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    //create Link
                    //var token = userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var url = Url.Action("ConfirmedEmail", "Account",new {token=token ,userId=user.Id });
                    // send Email


                  //  await signInManager.SignInAsync(user, true);
                    return RedirectToAction("Login", "Account");
                }
                foreach (var Error in result.Errors)
                {
                    ModelState.AddModelError("", Error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult>  Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ExternalLogin(string Provider)
        {
            var Properties = signInManager.ConfigureExternalAuthenticationProperties(Provider, "/Account/ExternalResponse");
            return Challenge(Properties, Provider);
        }

        public async Task<IActionResult> ExternalResponse()
        {
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info==null)
            {
                TempData["Message"] = "Login Failed";
                return RedirectToAction("Login");
            }
            var LoginResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider,info.ProviderKey,false);
            if (!LoginResult.Succeeded)
            {
                var Email = info.Principal.FindFirstValue(ClaimTypes.Email);
                var FirstName = info.Principal.FindFirstValue(ClaimTypes.GivenName);
                var LastName = info.Principal.FindFirstValue(ClaimTypes.Surname);

                var UserToCreate = new ApplicationUser
                {
                  Email=Email,
                  UserName=Email,
                   FirstName = FirstName,
                    LastName = LastName
                };

                var createResult = await userManager.CreateAsync(UserToCreate);

                if (createResult.Succeeded)
                {
                    var exLoginResult = await userManager.AddLoginAsync(UserToCreate, info);
                    if (exLoginResult.Succeeded)
                    {
                        await signInManager.SignInAsync(UserToCreate, false, info.LoginProvider);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        await userManager.DeleteAsync(UserToCreate);
                    }

                }
               
                    return RedirectToAction("Login");
                

            }
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> Info()
        {
            var CurrentUser = await userManager.GetUserAsync(User);
            if (CurrentUser !=null)
            {
                var model = mapper.Map<UserViewModel>(CurrentUser);
                return View(model);
            }
            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> Info(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var CurrentUser = await userManager.GetUserAsync(User);
                if (CurrentUser != null)
                {
                    CurrentUser.FirstName = model.FirstName;
                    CurrentUser.LastName = model.LastName;

                    var result = await userManager.UpdateAsync(CurrentUser);
                    if (result.Succeeded)
                    {
                        TempData["Succeeded"] = stringLocalizer["SuccessMessage"]?.Value;
                        return RedirectToAction("Info");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }
                  

                }
                else
                {
                    return NotFound();
                }
               
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            var CurrentUser = await userManager.GetUserAsync(User);
            if (CurrentUser != null)
            {
                if (ModelState.IsValid)
            {
              
                    

                    var result = await userManager.ChangePasswordAsync(CurrentUser,model.CurrentPassword,model.NewPassword);
                    if (result.Succeeded)
                    {
                        await signInManager.SignOutAsync();
                        TempData["Succeeded"] = stringLocalizer["ChangePassword"]?.Value;

                        return RedirectToAction("Login");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }


                }
               

            }
            else
            {
                return NotFound();
            }
            return View("Info", mapper.Map<UserViewModel>(CurrentUser));
        }


        [HttpPost]
        public async Task<IActionResult> AddPassword(AddPasswordViewModel model)
        {
            var CurrentUser = await userManager.GetUserAsync(User);
            if (CurrentUser != null)
            {
                if (ModelState.IsValid)
                {



                    var result = await userManager.AddPasswordAsync(CurrentUser, model.Password);
                    if (result.Succeeded)
                    {
                      
                        TempData["Succeeded"] = stringLocalizer["AddPassword"]?.Value;

                        return RedirectToAction("Info");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }


                }


            }
            else
            {
                return NotFound();
            }
            return View("Info", mapper.Map<UserViewModel>(CurrentUser));
        }
    }
}
