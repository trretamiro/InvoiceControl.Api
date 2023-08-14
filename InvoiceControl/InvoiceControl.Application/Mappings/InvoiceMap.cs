﻿using AutoMapper;
using InvoiceControl.Dto.Dto;
using InvoiceControl.Domain.Models;

namespace InvoiceControl.Application.Mappings
{
  public class InvoiceMap : Profile
  {
    public InvoiceMap() 
    {
      CreateMap<InvoiceServicesDto, InvoiceServices>();
        //.ForMember(x => x.Provider, x => x.Ignore())
        //.ForMember(x => x.Receiver, x => x.Ignore());

      CreateMap<InvoiceServices, InvoiceServicesDto>();
    }
  }
}
