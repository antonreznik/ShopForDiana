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
    public class WasherService : IService<DTOwasher>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public WasherService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        public void Create(DTOwasher model)
        {
            _unitOfWork.WasherRepository.Create(_mapper.Map<Washer>(model));
        }

        public void DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByModel(DTOwasher model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTOwasher> GetAll()
        {
            return _mapper.Map<IEnumerable<DTOwasher>>(_unitOfWork.WasherRepository.GetAll().AsEnumerable());
        }

        public DTOwasher GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(DTOwasher model)
        {
            throw new NotImplementedException();
        }
    }
}
