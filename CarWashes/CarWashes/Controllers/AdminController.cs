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

namespace CarWashes.Controllers
{
    public class AdminController : Controller
    {
        private IService<DTOwasher> _washerService;
        private IMapper _mapper;

        public AdminController(IService<DTOwasher> washerService)
        {
            this._washerService = washerService;
            this._mapper = AutoMapperConfiguration.GetMapper();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddWasher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWasher(WasherViewModel washer)
        {
            _washerService.Create(_mapper.Map<DTOwasher>(washer));
            return View();
        }
    }
}