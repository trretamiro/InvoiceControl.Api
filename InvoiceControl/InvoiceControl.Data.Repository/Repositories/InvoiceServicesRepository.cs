using InvoiceControl.Domain.Interfaces.Repositories;
using InvoiceControl.Domain.Models;

namespace InvoiceControl.Data.Repository.Repositories
{
  public class InvoiceServicesRepository : IInvoiceServicesRepository
  {
    private readonly InvoiceContext _invoiceContext;
    private readonly bool _dispose = false;

    public InvoiceServicesRepository(InvoiceContext invoiceContext)
    {
      _invoiceContext = invoiceContext;   
    }

    public async Task IncludeInvoiceService(InvoiceServices invoiceServ)
    {
      await _invoiceContext.InvoiceServices.AddAsync(invoiceServ);
    }

    ~InvoiceServicesRepository() => Dispose();

    public void Dispose()
    {
      if(!_dispose) _invoiceContext.Dispose();

      GC.SuppressFinalize(this);
    }
  }
}
