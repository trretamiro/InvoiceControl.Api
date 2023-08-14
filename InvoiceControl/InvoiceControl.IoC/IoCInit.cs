using Microsoft.Extensions.DependencyInjection;

namespace InvoiceControl.IoC
{
  public static class IoCInit
  {
    public static void RegisterServices(this IServiceCollection services) 
    {
      ServicesData.Register(services);

      ServiceApplication.Register(services);

      ServiceDomain.Register(services);

      //ServicesInfra.Register(services);
    }
  }
}
