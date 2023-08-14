using InvoiceControl.Data;
using InvoiceControl.Data.Dao;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceControl.IoC
{
  internal static class ServicesData
  {
    internal static void Register(IServiceCollection servCol)
    {
      servCol.AddScoped<InvoiceContext>();
      servCol.AddScoped<DapperContext>();

      servCol.AddScoped<InvoiceServicesDao>();
    }
  }
}