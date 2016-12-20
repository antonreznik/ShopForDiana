using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace Shop.Controllers
{
    public class SubCategoryController : Controller
    {
        
        public ActionResult CreateSubCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSubCategory(SubCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var x = model;
            }
            
            return View();
        }
    }
}