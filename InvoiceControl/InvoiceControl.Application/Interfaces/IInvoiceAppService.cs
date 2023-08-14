using InvoiceControl.Dto.Dto;
using InvoiceControl.Dto.Validation;

namespace InvoiceControl.Application.Interfaces
{
  public interface IInvoiceAppService
  {
    public ValidationResult Register(InvoiceServicesDto invoiceServicesDto);
  }
}
