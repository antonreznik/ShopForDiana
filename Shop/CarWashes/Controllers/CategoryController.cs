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
        public ActionResult UpdateCategory()
        {
            var x = _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAll());
            return View(_mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAll()));
        }

        [Authorize]
        [HttpPost]
        public ActionResult UpdateCategory(CategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(_mapper.Map<CategoryDTO>(category));
                return RedirectToAction("UpdateCategory", "Category");
            }

            return View();
        }

        [Authorize]
        public ActionResult ShowHideCategory()
        {
            return View(_mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAll()));
        }

        [Authorize]
        [HttpPost]
        public ActionResult ShowHideCategory(CategoryViewModel category)
        {
            _categoryService.Visibility(_mapper.Map<CategoryDTO>(category));
            return RedirectToAction("ShowHideCategory", "Category");
        }

        public ActionResult GetDropDownListOfAllCategories()
        {
            var categories = _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAll());
            var list = new List<SelectListItem>();
            foreach(var category in categories)
            {
                list.Add(new SelectListItem { Text = category.Name, Value = category.CategoryId.ToString() });
            }

            return View(list);
        }
    }
}