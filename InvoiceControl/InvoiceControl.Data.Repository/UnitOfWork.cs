﻿using InvoiceControl.Domain.Interfaces;
using InvoiceControl.Dto.Validation;

namespace InvoiceControl.Data.Repository
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly InvoiceContext _context;

    public UnitOfWork(InvoiceContext context) =>
      _context = context;
    

    public async Task<bool> Commit()
    {
      var success = (await _context.SaveChangesAsync()) > 0;     

      return success;
    }

    public void Dispose() =>
      _context.Dispose();    

    public Task Rollback()
    {
      return Task.CompletedTask;
    }
  }
}
