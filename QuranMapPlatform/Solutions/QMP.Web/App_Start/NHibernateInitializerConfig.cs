
using Framework.Core.Domain.Events;
using Framework.Data.NHibernate;
using Framework.Data.NHibernate.Web.Mvc;
using Framework.Web.Mvc.Castle;
using Microsoft.Practices.ServiceLocation;
using QMP.Infrastructure.NHibernateMaps;
using System.Web;
using System.Web.Mvc;

namespace QMP.Web
{
    public class NHibernateInitializerConfig
    {
        public NHibernateInitializerConfig(HttpApplication app, WebSessionStorage storage)
        {
            webSessionStorage = storage;
            application = app;
        }
     
        private WebSessionStorage webSessionStorage;
        private HttpApplication application;
        public static void Initialize(HttpApplication app,WebSessionStorage storage )
        {

            NHibernateInitializer.Instance().InitializeNHibernateOnce(new NHibernateInitializerConfig(app,storage).InitialiseNHibernateSessions);
        }

        public void InitialiseNHibernateSessions()
        {
            NHibernateSession.ConfigurationCache = new NHibernateConfigurationFileCache();

            NHibernateSession.Init(
                this.webSessionStorage,
                new[] { application.Server.MapPath("~/bin/QMP.Infrastructure.dll") },
                new AutoPersistenceModelGenerator().Generate(),
                application.Server.MapPath("~/NHibernate.config"));
        }
    }
}
