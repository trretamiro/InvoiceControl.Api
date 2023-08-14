using InvoiceControl.Domain.Models;
using InvoiceControl.Dto.Validation;

namespace InvoiceControl.Domain.Interfaces.Repositories
{
  public interface IInvoiceServicesRepository : IDisposable
  {
    Task IncludeInvoiceService(InvoiceServices invoiceServ);
  }
}
