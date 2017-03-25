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
    public class SubCategoryController : Controller
    {
        private IService<SubCategoryDTO> _subCategoryService;
        private IMapper _mapper;

        public SubCategoryController(IService<SubCategoryDTO> subCategoryService)
        {
            _subCategoryService = subCategoryService;
            _mapper = AutoMapperConfiguration.GetMapper();
        }
        
        [Authorize]
        public ActionResult CreateSubCategory()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateSubCategory(SubCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _subCategoryService.Create(_mapper.Map<SubCategoryDTO>(model));
                return RedirectToAction("Index", "Admin");
            }
            
            return View(model);
        }
    }
}