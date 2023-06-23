using Microsoft.AspNetCore.Mvc;
using Session1.Service;

namespace Session1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IProductService _productService;

        public ProductController(IProductService productService,IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get(string key)
        {
            try 
            {
                string appSettingValue = _productService.GetAppSetting(key);

                // Retrieve the value from the environment
                string environmentValue = _productService.GetEnvironmentVariable(key);

                // Return the values
                return Ok(new { AppSettingValue = appSettingValue, EnvironmentValue = environmentValue });
            }
            catch (Exception ex) 
            {
                var errorController = _serviceProvider.GetRequiredService<ErrorController>();
                return errorController.MyException();
            }
        }
    }
}
