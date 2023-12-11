using CDBCalculation.Application.Abastraction;
using CDBCalculation.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace CDBCalculation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CDBController : ControllerBase
    {
        public CDBController()
        {
                
        }

        [HttpPost]
        public async Task<IActionResult> RequestCDBCalculcation([FromServices] ICDBCalculationService service,
                                                                [FromBody] CDBRequest request)
        {
            try
            {
                var result = await service.CalculateCDBByPeriod(request);

                if (result is null)
                    return BadRequest(result);

                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
           
        }
    }
}
