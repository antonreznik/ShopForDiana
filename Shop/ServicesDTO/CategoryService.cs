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
        private IRepository<Category> _repository;

        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository)
        {
            this._unitOfWork = unitOfWork;
            _mapper = AutoMapperConfiguration.GetMapper();
            _repository = repository;
        }

        public void Create(CategoryDTO model)
        {          
            _repository.Create(_mapper.Map<Category>(model));
        }

        
        public IEnumerable<CategoryDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<CategoryDTO>>(_repository.GetAll().ToList());
            //return _mapper.Map<IEnumerable<CategoryDTO>>(_unitOfWork.CategoryRepository.GetAll().ToList());
        }

        public CategoryDTO GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryDTO model)
        {
            //_unitOfWork.CategoryRepository.Update(_mapper.Map<Category>(model));
            _repository.Update(_mapper.Map<Category>(model));
        }

        public void Visibility(CategoryDTO model)
        {
            //_unitOfWork.CategoryRepository.Visibility(_mapper.Map<Category>(model));
            _repository.Update(_mapper.Map<Category>(model));
        }
    }
}
