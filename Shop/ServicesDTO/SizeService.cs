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

        public SizeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        public void Create(SizeDTO model)
        {
            _unitOfWork.SizeRepository.Create(_mapper.Map<Size>(model));
        }

        public SizeDTO GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SizeDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(SizeDTO model)
        {
            throw new NotImplementedException();
        }

        public void Visibility(SizeDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
