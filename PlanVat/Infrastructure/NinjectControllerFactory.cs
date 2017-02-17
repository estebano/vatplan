using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PlanVat.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            // tu umieść dodatkowe powiązania
        }

        protected override IController GetControllerInstance(RequestContext requestContext, 
            Type controllerType)
        {
            var controller = controllerType == null
                ? null
                : (IController)kernel.Get(controllerType);
            return controller;
        }
    }
}