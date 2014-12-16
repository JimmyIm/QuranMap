using Framework.Data.NHibernate;
using Framework.Specifications.NHibernate.Mappings;
using Framework.Testing.NUnit.NHibernate;
using NHibernate.Cfg;
using NUnit.Framework;
using System;
namespace QMP.Tests.QMP.Data
{
    public abstract class BaseDataGenratorTests
    {
        private Configuration configuration;
        [SetUp]
        public virtual void SetUp()
        {
            string[] mappingAssemblies = RepositoryTestsHelper.GetMappingAssemblies();
            var autoPersistenceModel = RepositoryTestsHelper.GetAutoPersistenceModel(mappingAssemblies);
            //this.configuration = NHibernateSession.Init(
            //    new SimpleSessionStorage(),
            //    mappingAssemblies,
            //    new AutoPersistenceModelGenerator().Generate(),
            //    "../../../../Solutions/QMP.Web/NHibernate.config");
            ServiceLocatorInitializer.Init();
            // RepositoryTestsHelper.InitializeNHibernateSession();   
            NHibernateSession.Init(new SimpleSessionStorage(), mappingAssemblies, autoPersistenceModel, "../../../../Solutions/QMP.Web/NHibernate.config");
        }

        [TearDown]
        public virtual void TearDown()
        {
            NHibernateSession.CloseAllSessions();
            NHibernateSession.Reset();
        }
    }
}
