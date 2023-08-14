using InvoiceControl.Data;
using Microsoft.EntityFrameworkCore;

namespace InvoiceControl.Api.Configurations
{
  public static class DatabaseConfig
  {
    public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
      if (services == null) throw new ArgumentNullException(nameof(services));

      services.AddDbContext<InvoiceContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("InvoiceConnection")!,
          b => b.MigrationsAssembly("InvoiceControl.Data")));
    }
  }
}
