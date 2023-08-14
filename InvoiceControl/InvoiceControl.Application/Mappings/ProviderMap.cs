using AutoMapper;
using InvoiceControl.Domain.Models;
using InvoiceControl.Dto.Dto;

namespace InvoiceControl.Application.Mappings
{
  public class ProviderMap : Profile
  {
    public ProviderMap()
    {
      CreateMap<InvoiceServicesDto, InvoiceServices>();

      CreateMap<InvoiceServices, InvoiceServicesDto>();
    }
  }
}
