using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Dto.Dto
{
  public class InvoiceServicesDto
  {
    public int Id { get; set; }
    public int InvoiceNumber { get; set; }
    public DateTime DateIssue { get; set; }
    public string VerificationCode { get; set; } = string.Empty;
    public string IntermediateIdent { get; set; } = string.Empty;
    public string IntermediateName { get; set; } = string.Empty;
    public string ServiceDesc { get; set; } = string.Empty;
    public int Amount { get; set; }
    public Decimal UnitaryValue { get; set; }
    public Decimal ItemValue { get; set; }
    public Decimal NoteValue { get; set; }
    public Decimal Taxes { get; set; }
    public Decimal INSS { get; set; }
    public Decimal IRRF { get; set; }
    public Decimal CSLL { get; set; }
    public Decimal CONFIS { get; set; }
    public Decimal PIS { get; set; }
    public Decimal PASEB { get; set; }
    public string ServiceCode { get; set; } = string.Empty;
    public Decimal DeductionsValue { get; set; }
    public Decimal BasisCalculation { get; set; }
    public Decimal Aliquot { get; set; }
    public Decimal ISSValue { get; set; }
    public Decimal Credit { get; set; }
    public string Information { get; set; } = string.Empty;
    public int ReceiverId { get; set; }
    public int ProviderId { get; set; }
    public ReceiverDto? ReceiverDto { get; set; }
    public ProviderDto? ProviderDto { get; set; }
  }
}
