using AutoMapper;
using InvoiceControl.Domain.Models;
using InvoiceControl.Dto.Dto;

namespace InvoiceControl.Application.Mappings
{
  public class AddressMap : Profile
  {
    public AddressMap()
    {
      CreateMap<AddressDto, Address>();

      CreateMap<Address, AddressDto>();
    }
  }
}
