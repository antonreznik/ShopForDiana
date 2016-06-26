using DataAccess;
using DTOmodels;
using Interfaces;
using Ninject;
using ServiceInterfaces;
using ServicesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NinjectContainer
{
    public class NinjResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            _kernel.Bind<IService<DTOwasher>>().To<WasherService>();
        }
    }
}
