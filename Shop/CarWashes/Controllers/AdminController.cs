using AutoMapper;
using AutoMapperConfig;
using CustomIdentity.Models;
using DTOmodels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ViewModels;
using ViewModels.IdentityViewModels;

namespace Shop.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        //private ShopUserManager UserManager
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().GetUserManager<ShopUserManager>();
        //    }
        //}

        public ActionResult Index()
        {
            //ShopUser user = new ShopUser { UserName = "admin" };
            //IdentityResult result = UserManager.Create(user, "123456");
            //if (result.Succeeded)
            //{
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    AddErrorsFromResult(result);
            //}
            return View();
        }

        //private void AddErrorsFromResult(IdentityResult result)
        //{
        //    foreach (string error in result.Errors)
        //    {
        //        ModelState.AddModelError("", error);
        //    }
        //}
    }
}