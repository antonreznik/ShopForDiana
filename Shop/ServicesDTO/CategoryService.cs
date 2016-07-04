using AutoMapper;
using AutoMapperConfig;
using CoreModels;
using DTOmodels;
using Interfaces;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesDTO
{
    public class CategoryService : IService<CategoryDTO>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        public void Create(CategoryDTO model)
        {
            _unitOfWork.CategoryRepository.Create(_mapper.Map<Category>(model));
        }

        public void DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByModel(CategoryDTO model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<CategoryDTO>>(_unitOfWork.CategoryRepository.GetAll().ToList());
        }

        public CategoryDTO GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
