using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Domain.Interfaces
{
  public interface IUnitOfWork : IDisposable
  {
    Task<bool> Commit();
    Task Rollback();
  }
}
