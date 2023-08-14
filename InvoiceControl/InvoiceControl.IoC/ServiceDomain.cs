using InvoiceControl.Data.Repository;
using InvoiceControl.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using InvoiceControl.Domain.Interfaces.Repositories;
using InvoiceControl.Data.Repository.Repositories;

namespace InvoiceControl.IoC
{
  internal static class ServiceDomain
  {
    internal static void Register(IServiceCollection servCol)
    {
      servCol.AddScoped<IUnitOfWork, UnitOfWork>();
      servCol.AddScoped<IInvoiceServicesRepository, InvoiceServicesRepository>();
      servCol.AddScoped<IAddressRepository, AddressRepository>();
      servCol.AddScoped<IReceiverRepository, ReceiverRepository>();
      servCol.AddScoped<IProviderRepository, ProviderRepository>();

    }
  }
}
