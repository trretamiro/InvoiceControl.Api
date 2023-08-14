using InvoiceControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceControl.Data.Mappings
{
  public class InvoiceServicesMap : IEntityTypeConfiguration<InvoiceServices>
  {
    public void Configure(EntityTypeBuilder<InvoiceServices> builder)
    {
      builder.ToTable("Invoice_Services");
      
      builder.Property(x => x.InvoiceNumber)
        .HasColumnType("bigint")
        .HasMaxLength(10);

      builder.Property(i => i.DateIssue)
        .HasColumnType("date")        
        .IsRequired();

      builder.Property(i => i.VerificationCode)
        .HasColumnType("varchar(10)")
        .HasMaxLength(10)
        .IsRequired();

      builder.Property(i => i.IntermediateIdent)
        .HasColumnType("varchar(20)")
        .HasMaxLength(20);

      builder.Property(i => i.IntermediateName)
        .HasColumnType("varchar(200)")
        .HasMaxLength(200);

      builder.Property(i => i.ServiceDesc)
        .HasColumnType("varchar(2000)")
        .HasMaxLength(2000)
        .IsRequired();

      builder.Property(i => i.Amount)
        .HasColumnType("int")
        .HasMaxLength(10);

      builder.Property(i => i.UnitaryValue)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.ItemValue)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.NoteValue)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);
      
      builder.Property(i => i.Taxes)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(30);

      builder.Property(i => i.INSS)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.IRRF)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.CSLL)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.CONFIS)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.PIS)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.PASEB)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);        

      builder.Property(i => i.ServiceCode)
        .HasColumnType("varchar(500)")
        .HasMaxLength(500);

      builder.Property(i => i.DeductionsValue)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.BasisCalculation)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.Aliquot)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.ISSValue)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.Credit)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.Property(i => i.Information)
        .HasColumnType("varchar(1000)")
        .HasMaxLength(1000);

      builder.Property(i => i.ISSValue)
        .HasColumnType("decimal(10,3)")
        .HasMaxLength(20);

      builder.HasOne(i => i.Receiver)
        .WithMany()
        .HasForeignKey(i => i.ReceiverId);

      builder.HasOne(i => i.Provider)
        .WithMany()
        .HasForeignKey(i => i.ProviderId);
    }
  }
}
