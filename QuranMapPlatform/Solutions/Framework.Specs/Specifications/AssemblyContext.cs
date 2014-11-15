namespace Framework.Specifications
{
    using System;

    using Machine.Specifications;

    using global::Framework.Testing.NUnit.NHibernate;

    public class AssemblyContext : IAssemblyContext
    {
        public void OnAssemblyStart()
        {
            RepositoryTestsHelper.InitializeNHibernateSession();
        }

        public void OnAssemblyComplete()
        {
            RepositoryTestsHelper.Shutdown();
        }
    }
}