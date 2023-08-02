using InvoiceControl.Application.Interfaces;

namespace InvoiceControl.Application.Services
{
  public class InvoiceAppService : IInvoiceAppService
  {
    private readonly IInvoiceAppService _invoiceAppService;

    public InvoiceAppService(IInvoiceAppService invoiceAppService)
    {
      _invoiceAppService = invoiceAppService;
    }



  }
}
