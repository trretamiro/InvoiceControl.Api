using InvoiceControl.Application.Dao;
using InvoiceControl.Dto.Dto;
using Microsoft.EntityFrameworkCore;
using Dapper;
using System.Net.Mime;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace InvoiceControl.Data.Dao
{
  public class InvoiceServicesDao : IInvoiceServicesDao
  {
    private readonly IDbConnection _connection;

    public InvoiceServicesDao(DapperContext dapperContext)
    {
      _connection = dapperContext.GetConnection();
    }

    public IEnumerable<InvoiceServicesDto> GetAll()
    {
      string query = "SELECT * FROM InvoiceServices";

      var results = _connection.Query<InvoiceServicesDto>(query);

      return results;
    }
  }
}
