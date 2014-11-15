namespace Framework.Data.NHibernate
{
  using Framework.Core.Domain;

  public static class SessionFactoryKeyHelper
  {
    public static string GetKey()
    {
      var provider = SafeServiceLocator<ISessionFactoryKeyProvider>.GetService();
      return provider.GetKey();
    }

    public static string GetKeyFrom(object anObject)
    {
      var provider = SafeServiceLocator<ISessionFactoryKeyProvider>.GetService() ?? new DefaultSessionFactoryKeyProvider();
      return provider.GetKeyFrom(anObject);
    }
  }
}