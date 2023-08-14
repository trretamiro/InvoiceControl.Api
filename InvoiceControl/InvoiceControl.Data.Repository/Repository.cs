using InvoiceControl.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InvoiceControl.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    private readonly InvoiceContext _dbContext;

    public Repository(InvoiceContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task AddAsync(TEntity entity)
    {
      _dbContext.Add(entity);
      await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
      return await _dbContext.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
      var entity = await _dbContext.Set<TEntity>().FindAsync(id);
      if (entity == null)
      {
        throw new EntityNotFoundException($"Entity with ID {id} not found.");
      }
      return entity;
    }

    public async Task RemoveAsync(TEntity entity)
    {
      _dbContext.Remove(entity);
      await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
      _dbContext.Update(entity);
      await _dbContext.SaveChangesAsync();
    }
  }
  public class EntityNotFoundException : Exception
  {
    public EntityNotFoundException(string message) : base(message)
    {
    }
  }
}