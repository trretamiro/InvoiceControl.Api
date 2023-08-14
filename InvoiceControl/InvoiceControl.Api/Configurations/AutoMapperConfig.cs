using InvoiceControl.Application.Mappings;
using AutoMapper;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceControl.Api.Configurations
{
  public static class AutoMapperConfig
  {
    public static void AddAutoMapperConfiguration(this IServiceCollection services)
    {
      if (services == null) throw new ArgumentNullException(nameof(services));

      var config = new MapperConfiguration(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));
      services.AddAutoMapper(typeof(InvoiceMap), typeof(AddressMap), typeof(ReceiverMap), typeof(ProviderMap));
      config.AssertConfigurationIsValid();
      services.AddSingleton<AutoMapper.IConfigurationProvider>(config);
      
    }
  }
}