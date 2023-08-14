using AutoMapper;
using InvoiceControl.Application.Interfaces;
using InvoiceControl.Application.Mappings;
using InvoiceControl.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceControl.IoC
{
  internal static class ServiceApplication
  {
    internal static void Register(IServiceCollection servCol)
    {
      servCol.AddScoped<IInvoiceAppService, InvoiceAppService>();
      //servCol.AddScoped<IMapper, Mapper>();
      //servCol.AddScoped<IRequestHandler<CreateInvoiceCommand, ValidationResult>, CreateInvoiceCommandHandler>();
    }
  }
}
