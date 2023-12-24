using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoDemo.Models;
using MoDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoDemo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser>userManager,SignInManager<ApplicationUser>signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserVM userVM)
        {
            if (ModelState.IsValid)
            {
                //check in db
                ApplicationUser usermodel = await userManager.FindByNameAsync(userVM.UserName);
                if (usermodel != null)
                {
                    bool found = await userManager.CheckPasswordAsync(usermodel, userVM.Password);
                    if (found == true)
                    {
                        //cookies
                        await signInManager.SignInAsync(usermodel,userVM.RememberMe);
                        return RedirectToAction("Index","Employee");
                    }
                }
                else
                {
                    ModelState.AddModelError("","user name or password not valid");
                }
            }
            return View(userVM);
        }

        [HttpGet]
        public IActionResult Registeration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Registeration(RegistarUserVM newUserVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser usermodel = new ApplicationUser();
                usermodel.UserName = newUserVM.UserName;
                usermodel.PasswordHash = newUserVM.Password;
                usermodel.Adress = newUserVM.Address;
                //save in db
                IdentityResult result = await userManager.CreateAsync(usermodel,newUserVM.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(usermodel,"Student");
                    await signInManager.SignInAsync(usermodel,false); /*Id,name,role*/
                    //List<Claim> claims = new List<Claim>();
                    //claims.Add(new Claim("color","red"));
                    //await signInManager.SignInWithClaimsAsync(usermodel,false,claims);/*Id,name,role and extra data from clim*/
                    //create cookies
                    return RedirectToAction("Index","Employee");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("Password",item.Description);
                    }
                }
            }
            return View(newUserVM);
        }


        public IActionResult Logout()
        {
            signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  AddAdmin(RegistarUserVM newUserVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser usermodel = new ApplicationUser();
                usermodel.UserName = newUserVM.UserName;
                usermodel.PasswordHash = newUserVM.Password;
                usermodel.Adress = newUserVM.Address;
                //save in db
                IdentityResult result = await userManager.CreateAsync(usermodel, newUserVM.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(usermodel,"Admin");
                    await signInManager.SignInAsync(usermodel, false); /*Id,name,role*/
                    //List<Claim> claims = new List<Claim>();
                    //claims.Add(new Claim("color","red"));
                    //await signInManager.SignInWithClaimsAsync(usermodel,false,claims);/*Id,name,role and extra data from clim*/
                    //create cookies
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("Password", item.Description);
                    }
                }
            }
            return View(newUserVM);
        }
    }
}
