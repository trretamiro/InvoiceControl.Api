using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.Dto.Validation
{
  public class ValidationResult
  {
    public bool IsValid => Errors.Count == 0;
    public List<string> Errors { get; } = new List<string>();

    public void AddError(string error)
    {
      Errors.Add(error);
    }
  }
}
