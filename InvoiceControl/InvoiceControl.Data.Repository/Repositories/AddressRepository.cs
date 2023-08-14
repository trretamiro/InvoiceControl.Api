using InvoiceControl.Data.Repository;
using InvoiceControl.Domain.Interfaces.Repositories;
using InvoiceControl.Domain.Models;

namespace InvoiceControl.Data.Repository.Repositories
{
  public class AddressRepository : IAddressRepository
  {
    private readonly InvoiceContext _invoiceContext;
    private readonly bool _dispose = false;

    public AddressRepository(InvoiceContext invoiceContext)
    {
      _invoiceContext = invoiceContext; 
    }

    public Task Include(Address address)
    {
      throw new NotImplementedException();
    }

    ~AddressRepository() => Dispose();

    public void Dispose()
    {
      if (!_dispose) _invoiceContext.Dispose();

      GC.SuppressFinalize(this);
    }
  }
}
