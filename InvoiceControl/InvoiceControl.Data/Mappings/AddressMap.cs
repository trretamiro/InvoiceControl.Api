using InvoiceControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Data.Mappings
{
  public class AddressMap : IEntityTypeConfiguration<Address>
  {
    public void Configure(EntityTypeBuilder<Address> builder)
    {
      builder.ToTable(nameof(Address));

      builder.HasKey(a => a.Id);

      builder.Property(a => a.Id)
        .HasColumnType("bigint")
        .HasMaxLength(20);

      builder.Property(a => a.Street)
        .HasColumnType("varchar(150)")
        .HasMaxLength(150)
        .IsRequired();

      builder.Property(a => a.Number)
        .HasColumnType("int")
        .HasMaxLength(7)
        .IsRequired();

      builder.Property(a => a.PostalCode)
        .HasColumnType("varchar(14)")
        .HasMaxLength(14);

      builder.Property(a => a.Complement)
        .HasColumnType("varchar(50)")
        .HasMaxLength(50);

      builder.Property(a => a.Neighborhood)
        .HasColumnType("varchar(50)")
        .HasMaxLength(50);

      builder.Property(a => a.State)
        .HasColumnType("char(3)")
        .HasMaxLength(3)
        .IsRequired();

      builder.Property(a => a.City)
        .HasColumnType("varchar(50)")
        .HasMaxLength(50);

      builder.Property(a => a.Telephone)
        .HasColumnType("varchar(12)")
        .HasMaxLength(12);

      builder.Property(a => a.Email)
        .HasColumnType("varchar(100)")
        .HasMaxLength(100);
    }
  }
}
