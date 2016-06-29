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
        //private IService<DTOwasher> _washerService;
        //private IMapper _mapper;
        //private ShopUserManager UserManager
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().GetUserManager<ShopUserManager>();
        //    }
        //}

        //public AdminController(IService<DTOwasher> washerService)
        //{
        //    this._washerService = washerService;
        //    this._mapper = AutoMapperConfiguration.GetMapper();
        //}

        public ActionResult Index()
        {
            //ShopUser user = new ShopUser { UserName = "admin" };
            //IdentityResult result = UserManager.Create(user, "123456");
            //if (result.Succeeded)
            //{
            //    return RedirectToAction("Index");
            //}
            //else {
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

        //public ActionResult AddWasher()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult AddWasher(WasherViewModel washer)
        //{
        //    _washerService.Create(_mapper.Map<DTOwasher>(washer));
        //    return View();
        //}
    }
}