using api.Errors;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("errors/{code}")]
    public class ErrorController : BaseApiController
    {
        //[Route("errors/{code}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        //[HttpGet]
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
