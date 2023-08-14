using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace InvoiceControl.Data
{
  public class DapperContext
  {
    private readonly IDbConnection _connection;

    public DapperContext(IConfiguration configuration)
    {
      string connectionString = configuration.GetConnectionString("InvoiceConnection");
      _connection = new SqlConnection(connectionString);
    }

    public IDbConnection GetConnection()
    {
      return _connection;
    }
  }
}
