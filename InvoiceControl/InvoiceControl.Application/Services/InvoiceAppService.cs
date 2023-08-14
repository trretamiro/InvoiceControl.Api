using InvoiceControl.Application.Interfaces;
using InvoiceControl.Domain.Models;
using AutoMapper;
using InvoiceControl.Dto.Dto;
using InvoiceControl.Domain.Interfaces.Repositories;
using InvoiceControl.Dto.Validation;

namespace InvoiceControl.Application.Services
{
  public class InvoiceAppService : IInvoiceAppService
  {
    private readonly IInvoiceServicesRepository _invoiceRepository;
    private readonly IMapper _mapper;

    public InvoiceAppService(IInvoiceServicesRepository invoiceRepository,
      IMapper mapper)
    {
      _invoiceRepository = invoiceRepository;
      _mapper = mapper;
    }

    public ValidationResult Register(InvoiceServicesDto invoiceServicesDto)
    {
      var validation = new ValidationResult();

      try
      {
        //var registerInvoiceService = _mapper.Map<InvoiceServices>(invoiceServicesDto);
        var conclusion = _invoiceRepository.IncludeInvoiceService(new InvoiceServices());
        return validation;
      }
      catch (Exception ex)
      {
        validation.AddError(ex.Message.ToString());
        return validation;
      }
    }

  }
}
