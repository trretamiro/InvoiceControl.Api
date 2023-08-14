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
  public class ReceiverMap : IEntityTypeConfiguration<Receiver>
  {
    public void Configure(EntityTypeBuilder<Receiver> builder)
    {

      builder.ToTable("Receiver");

      builder.HasKey(r => r.Id);

      builder.Property(r => r.Id)
        .HasColumnType("bigint")
        .HasMaxLength(20);

      builder.Property(r => r.Name)
        .HasColumnType("varchar(100)")
        .HasMaxLength(100)
        .IsRequired();

      builder.Property(r => r.CPF)
        .HasColumnType("varchar(14)")
        .HasMaxLength(14);

      builder.Property(r => r.CNPJ)
        .HasColumnType("varchar(14)")
        .HasMaxLength(14);

      builder.Property(r => r.StateRegistration)
        .HasColumnType("int")
        .HasMaxLength(20);

      builder.HasOne(r => r.Address)
        .WithOne()
        .HasForeignKey<Receiver>(p => p.IdAdress)
        .HasConstraintName("CT_Receiver_Addresss");
    }
  }
}
