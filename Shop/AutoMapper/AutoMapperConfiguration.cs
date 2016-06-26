using AutoMapper;
using CoreModels;
using DTOmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace AutoMapperConfig
{
    public static class AutoMapperConfiguration
    {
        private static MapperConfiguration _config;

        static AutoMapperConfiguration()
        {
            ConfigureAutomapper();
        }

        private static void ConfigureAutomapper()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DTOwasher, Washer>();
                cfg.CreateMap<Washer, DTOwasher>();

                cfg.CreateMap<WasherViewModel, DTOwasher>();
                cfg.CreateMap<DTOwasher, WasherViewModel>();
            });
        }

        public static IMapper GetMapper()
        {
            return _config.CreateMapper();
        }
    }
}
