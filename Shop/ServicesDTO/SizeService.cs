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
    public class SizeService :IService<SizeDTO>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private IRepository<Size> _repository;

        public SizeService(IUnitOfWork unitOfWork, IRepository<Size> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        public void Create(SizeDTO model)
        {
            //_unitOfWork.SizeRepository.Create(_mapper.Map<Size>(model));
            _repository.Create(_mapper.Map<Size>(model));
        }

        public SizeDTO GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SizeDTO> GetAll()
        {
            //return _mapper.Map<IEnumerable<SizeDTO>>(_unitOfWork.SizeRepository.GetAll());
            return _mapper.Map<IEnumerable<SizeDTO>>(_repository.GetAll());
        }

        public void Update(SizeDTO model)
        {
            //_unitOfWork.SizeRepository.Update(_mapper.Map<Size>(model));
            _repository.Update(_mapper.Map<Size>(model));
        }

        public void Visibility(SizeDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
