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
    public class SubCategoryService : IService<SubCategoryDTO>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public SubCategoryService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        public void Create(SubCategoryDTO model)
        {
            _unitOfWork.SubCategoryRepository.Create(_mapper.Map<SubCategory>(model));
        }

        public IEnumerable<SubCategoryDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<SubCategoryDTO>>(_unitOfWork.SubCategoryRepository.GetAll().ToList());
        }

        public SubCategoryDTO GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubCategoryDTO model)
        {
            _unitOfWork.SubCategoryRepository.Update(_mapper.Map<SubCategory>(model));
        }

        public void Visibility(SubCategoryDTO model)
        {
            _unitOfWork.SubCategoryRepository.Visibility(_mapper.Map<SubCategory>(model));
        }
    }
}
