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
    public class ProductService : IService<ProductDTO>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper; 

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        public void Create(ProductDTO model)
        {
            _unitOfWork.ProductRepository.Create(_mapper.Map<Product>(model));
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetOne(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductDTO model)
        {
            throw new NotImplementedException();
        }

        public void Visibility(ProductDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
