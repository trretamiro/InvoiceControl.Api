using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Domain.Models
{
  public partial class Receiver
  {
    public int Id { get; set; }
    public int IdAdress { get; set; }
    public string CPF { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public long StateRegistration { get; set; }    

    public virtual Address? Address { get; set; }
  }
}
