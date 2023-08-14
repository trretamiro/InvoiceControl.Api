using InvoiceControl.Application.Interfaces;
using InvoiceControl.Domain.Interfaces;
using InvoiceControl.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace InvoiceControl.Application.Services
{
  public class InvoiceAppService : IInvoiceAppService
  {
    private readonly IInvoiceAppService _invoiceAppService;
    private readonly IInvoiceRepository _invoiceRepository;
    private readonly IAddressRepository _addressRepository;
    private readonly IReceiverRepository _receiverRepository;
    private readonly IProviderRepository _providerRepository;

    public InvoiceAppService(IInvoiceAppService invoiceAppService, 
      IInvoiceRepository invoiceRepository, 
      IAddressRepository addressRepository, 
      IReceiverRepository receiverRepository, 
      IProviderRepository providerRepository)
    {
      _invoiceAppService = invoiceAppService;
      _invoiceRepository = invoiceRepository;
      _addressRepository = addressRepository;
      _receiverRepository = receiverRepository;
      _providerRepository = providerRepository;
    }

    public void Register(InvoiceServices customerViewModel)
    {

    }


  }
}
