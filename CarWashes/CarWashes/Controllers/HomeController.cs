using AutoMapper;
using AutoMapperConfig;
using DTOmodels;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarWashes.Controllers
{
    public class HomeController : Controller
    {
        private IService<DTOwasher> _washerService;
        private IMapper _mapper;

        public HomeController(IService<DTOwasher> washerService)
        {
            this._washerService = washerService;
            this._mapper = AutoMapperConfiguration.GetMapper();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllWashes()
        {
            return Json(_washerService.GetAll(),JsonRequestBehavior.AllowGet);
        }
    }
}