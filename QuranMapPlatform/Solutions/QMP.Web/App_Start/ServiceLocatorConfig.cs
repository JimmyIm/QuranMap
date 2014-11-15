using Castle.Windsor;
using Castle.Windsor.Installer;
using CommonServiceLocator.WindsorAdapter;
using Framework.Core.Domain.Events;
using Framework.Web.Mvc.Castle;
using Microsoft.Practices.ServiceLocation;
using System.Web;
using System.Web.Mvc;

namespace QMP.Web
{
    public class ServiceLocatorConfig
    {
        public static void Initialize()
        {
           
            IWindsorContainer container = new WindsorContainer();

            container.Install(FromAssembly.This());

            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container));
            
            var windsorServiceLocator = new WindsorServiceLocator(container);
            DomainEvents.ServiceLocator = windsorServiceLocator;
            ServiceLocator.SetLocatorProvider(() => windsorServiceLocator);
        }
    }
}
