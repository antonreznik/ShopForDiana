﻿using AutoMapper;
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
    public class SizeController : Controller
    {
        private IService<SizeDTO> _sizeService;
        private IMapper _mapper;

        public SizeController(IService<SizeDTO> sizeService)
        {
            _sizeService = sizeService;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        [Authorize]
        public ActionResult CreateSize()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateSize(SizeViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Name = model.Name.ToUpper();
                _sizeService.Create(_mapper.Map<SizeDTO>(model));
                return RedirectToAction("Index", "Admin");
            }

            return View();
        }
    }
}