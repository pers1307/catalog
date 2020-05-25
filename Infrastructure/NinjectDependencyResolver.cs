using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catalog.Repositories;
using Ninject;

namespace Catalog.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
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
            kernel
                .Bind<IArticleRepository>()
                .To<ArticleRepository>();
            
            kernel
                .Bind<IProductRepository>()
                .To<ProductRepository>();
            
//                EmailSettings emailSettings = new EmailSettings()
//                {
//                    MailToAddress = ""
//                };
//
//                kernel
//                    .Bind<IOrderProcessor>()
//                    .To<EmailOrderProcessor>()
//                    .WithConstructorArgument("settings", emailSettings);
//
//                kernel
//                    .Bind<IAuthProvider>()
//                    .To<FormsAuthProvider>();


        }
    }
}