using InvoiceControl.Application.Interfaces;
using InvoiceControl.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceControl.IoC
{
  internal static class ServiceApplication
  {
    internal static void Register(IServiceCollection servCol)
    {
      servCol.AddScoped<IInvoiceAppService, InvoiceAppService>();
    }
  }
}
