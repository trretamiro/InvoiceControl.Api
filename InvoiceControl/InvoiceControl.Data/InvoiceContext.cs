using InvoiceControl.Data.Mappings;
using InvoiceControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace InvoiceControl.Data
{
  public partial class InvoiceContext : DbContext
  {

    #region Generated Configuration
    public virtual DbSet<InvoiceServices> InvoiceServices { get; set; } = null!;
    public virtual DbSet<Provider> ServiceProvider { get; set; } = null!;
    public virtual DbSet<Receiver> ServiceReceiver { get; set; } = null!;
    public virtual DbSet<Address> Address { get; set; } = null!;
    #endregion

    public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //base.OnModelCreating(modelBuilder);

      //modelBuilder.Ignore<ValidationResult>();

      #region Generated Configuration
      modelBuilder.ApplyConfiguration(new InvoiceServicesMap());
      modelBuilder.ApplyConfiguration(new ProviderMap());
      modelBuilder.ApplyConfiguration(new ReceiverMap());
      modelBuilder.ApplyConfiguration(new AddressMap());
      #endregion      
    }

  }

}