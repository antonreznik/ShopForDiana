using AutoMapper;
using AutoMapperConfig;
using DTOmodels;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace Shop.Controllers
{
    public class CategoryController : Controller
    {
        private IService<CategoryDTO> _categoryService;
        private IMapper _mapper;

        public CategoryController(IService<CategoryDTO> categoryService)
        {
            _categoryService = categoryService;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        [Authorize]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateCategory(CategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Create(_mapper.Map<CategoryDTO>(category));
                return RedirectToAction("Index", "Admin");
            }

            return View();
        }

        [Authorize]
        public ActionResult EditCategory()
        {
            return View(_mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAll()));
        }

        [Authorize]
        public ActionResult HideCategory()
        {
            return Json(_mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAll().
                   Where(x=>x.IsShown=true)), JsonRequestBehavior.AllowGet);
        }
    }
}