using InvoiceControl.Domain.Interfaces;
using InvoiceControl.Domain.Models;

namespace InvoiceControl.Data.Repositories
{
  public class InvoiceRepository : IInvoiceRepository
  {
    public void Add(InvoiceServices invoiceServ)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<InvoiceServices>> GetAll()
    {
      throw new NotImplementedException();
    }

    public Task<InvoiceServices> GetByEmail(string email)
    {
      throw new NotImplementedException();
    }

    public Task<InvoiceServices> GetById(Guid id)
    {
      throw new NotImplementedException();
    }

    public void Remove(InvoiceServices invoiceServ)
    {
      throw new NotImplementedException();
    }

    public void Update(InvoiceServices invoiceServ)
    {
      throw new NotImplementedException();
    }
  }
}
