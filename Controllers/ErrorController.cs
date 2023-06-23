using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Session1.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult MyException()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error;

            return StatusCode(500, "Error in request");
        }
    }
}
