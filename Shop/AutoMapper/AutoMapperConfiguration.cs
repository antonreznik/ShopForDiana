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
                cfg.CreateMap<CategoryDTO, Category>();
                cfg.CreateMap<Category, CategoryDTO>();

                cfg.CreateMap<CategoryViewModel, CategoryDTO>();
                cfg.CreateMap<CategoryDTO, CategoryViewModel>();

                cfg.CreateMap<SizeDTO, Size>();
                cfg.CreateMap<Size, SizeDTO>();

                cfg.CreateMap<SizeViewModel, SizeDTO>();
                cfg.CreateMap<SizeDTO, SizeViewModel>();

                cfg.CreateMap<SubCategoryDTO, SubCategory>();
                cfg.CreateMap<SubCategory, SubCategoryDTO>();
            });
        }

        public static IMapper GetMapper()
        {
            return _config.CreateMapper();
        }
    }
}
