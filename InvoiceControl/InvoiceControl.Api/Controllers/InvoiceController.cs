using InvoiceControl.Application.Interfaces;
using InvoiceControl.Dto.Dto;
using InvoiceControl.Dto.Validation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InvoiceControl.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class InvoiceController : ControllerBase
  {
    private readonly IInvoiceAppService _invoiceAppService;

    public InvoiceController(IInvoiceAppService invoiceAppService)
    {
      _invoiceAppService = invoiceAppService;
    }

    // GET: api/<InvoiceController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/<InvoiceController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<InvoiceController>
    [HttpPost]
    public IActionResult Post([FromBody] InvoiceServicesDto dto)
    {
      return Ok(_invoiceAppService.Register(dto));
    }

    // PUT api/<InvoiceController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<InvoiceController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
