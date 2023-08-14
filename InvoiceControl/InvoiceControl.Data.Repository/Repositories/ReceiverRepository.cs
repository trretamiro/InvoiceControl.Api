using InvoiceControl.Domain.Interfaces.Repositories;
using InvoiceControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Data.Repository.Repositories
{
  public class ReceiverRepository : IReceiverRepository //: Repository<Receiver>, IReceiverRepository
  {
    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}
