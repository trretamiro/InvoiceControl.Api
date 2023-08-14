using AutoMapper;
using InvoiceControl.Domain.Models;
using InvoiceControl.Dto.Dto;

namespace InvoiceControl.Application.Mappings
{
  public class ReceiverMap : Profile
  {
    public ReceiverMap() 
    {
      CreateMap<ReceiverDto, Receiver>();

      CreateMap<Receiver, ReceiverDto>();
    }
  }
}
