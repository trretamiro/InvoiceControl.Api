using InvoiceControl.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Application.Dao
{
  public interface IInvoiceServicesDao
  {
    public IEnumerable<InvoiceServicesDto> GetAll();
  }
}
