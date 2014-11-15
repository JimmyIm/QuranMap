namespace Tests.SharpArch.NHibernate
{
    using NUnit.Framework;

    using global::Framework.Core.Domain.PersistenceSupport;
    using global::Framework.Data.NHibernate;
    using global::Framework.Testing.NUnit;

    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void CanCastConcreteLinqRepositoryToInterfaceILinqRepository()
        {
            LinqRepository<MyEntity> concreteRepository = new LinqRepository<MyEntity>();
            ILinqRepository<MyEntity> castRepository = concreteRepository as ILinqRepository<MyEntity>;
            castRepository.ShouldNotBeNull();
        }
    }

    public class MyEntity
    {
        private string Name { get; set; }
    }
}