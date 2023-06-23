namespace Session1.Service
{
    public class ProductService : IProductService
    {
        private readonly IConfiguration _configuration;

        public ProductService(IConfiguration configuration) 
        { 
            _configuration = configuration;
        }

        public string GetAppSetting(string key)
        {
            return _configuration[key];
        }

        public string GetEnvironmentVariable(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }
    }
}
