using InvoiceControl.Domain.Interfaces.Repositories;
using InvoiceControl.Domain.Models;

namespace InvoiceControl.Data.Repository.Repositories
{
  public class ProviderRepository : IProviderRepository //: Repository<Provider>, IProviderRepository
  {
    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}
