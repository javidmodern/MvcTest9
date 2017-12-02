using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using MvcTest9.Domain.Concrete;
using MvcTest9.Domain.Abstract;
using MvcTest9.Domain.Entities;
namespace MvcTest9.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : System.Web.Mvc.IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<ICustomerRepository>().To<EFCustomerRepository>();
        }
    }
}