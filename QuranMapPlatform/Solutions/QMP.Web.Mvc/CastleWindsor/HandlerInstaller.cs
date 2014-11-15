namespace QMP.Web.Mvc.CastleWindsor
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Framework.Core.Domain.Commands;
    using Framework.Core.Domain.Events;

    public class HandlersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromAssemblyNamed("QMP.Tasks")
                    .BasedOn(typeof(ICommandHandler<>))
                    .WithService.FirstInterface().LifestylePerWebRequest());

            container.Register(
                Classes.FromAssemblyNamed("QMP.Tasks")
                    .BasedOn(typeof(ICommandHandler<,>))
                    .WithService.FirstInterface().LifestylePerWebRequest());

            container.Register(
                Classes.FromAssemblyNamed("QMP.Tasks")
                    .BasedOn(typeof(IHandles<>))
                    .WithService.FirstInterface().LifestylePerWebRequest());
        }
    }
}