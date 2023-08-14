using InvoiceControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Domain.Interfaces
{
  public interface IInvoiceRepository
  {
    Task<InvoiceServices> GetById(Guid id);
    Task<InvoiceServices> GetByEmail(string email);
    Task<IEnumerable<InvoiceServices>> GetAll();

    void Add(InvoiceServices invoiceServ);
    void Update(InvoiceServices invoiceServ);
    void Remove(InvoiceServices invoiceServ);
  }
}
