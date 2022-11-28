using BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace watiTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatsController : ControllerBase
    {
        private readonly IMathService mathService;
        public MatsController(IMathService mathService)
        {
            this.mathService = mathService;
        }
        
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> Add(SumModel model)
        {
            try
            {
               return Ok (mathService.Add(model.Numbet1, model.Numbet2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
