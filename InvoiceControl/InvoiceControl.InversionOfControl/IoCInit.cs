using InvoiceControl.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceControl.IoC
{
  public static class IoCInit
  {
    public static void RegisterServices(this IServiceCollection services) 
    {
      ServicesData.Register(services);      
    }
  }
}
