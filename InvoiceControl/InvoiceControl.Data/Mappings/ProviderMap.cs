using InvoiceControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceControl.Data.Mappings
{
  public class ProviderMap : IEntityTypeConfiguration<Provider>
  {
    public void Configure(EntityTypeBuilder<Provider> builder)
    {

      builder.ToTable("Provider");

      builder.HasKey(p => p.Id);

      builder.Property(p => p.Id)
        .HasColumnType("bigint")
        .HasMaxLength(20);

      builder.Property(p => p.Name)
        .HasColumnType("varchar(100)")
        .HasMaxLength(100)
        .IsRequired();

      builder.Property(p => p.CPF)
        .HasColumnType("varchar(14)")
        .HasMaxLength(14);

      builder.Property(p => p.CNPJ)
        .HasColumnType("varchar(14)")
        .HasMaxLength(14);

      builder.Property(p => p.StateRegistration)
        .HasColumnType("int")
        .HasMaxLength(20);

      builder.HasOne(p => p.Address)
        .WithOne()
        .HasForeignKey<Provider>(p => p.IdAdress)
        .HasConstraintName("CT_Provider_Addresss"); ;
    }
  }
}
