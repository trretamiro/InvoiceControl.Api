using InvoiceControl.Data;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceControl.IoC
{
  internal static class ServicesData
  {
    internal static void Register(IServiceCollection servCol)
    {
      servCol.AddScoped<InvoiceContext>();
    }
  }
}