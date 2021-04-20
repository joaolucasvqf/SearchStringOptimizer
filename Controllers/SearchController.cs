using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SearchStringOptimizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> OtimizaBusca(string Search)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
