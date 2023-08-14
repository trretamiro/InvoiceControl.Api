using InvoiceControl.IoC;

namespace InvoiceControl.Api.Configurations
{
  public static class DependencyInjectionConfig
  {
    public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
      if (services == null) throw new ArgumentNullException(nameof(services));

      IoCInit.RegisterServices(services);
    }
  }
}
