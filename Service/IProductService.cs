namespace Session1.Service
{
    public interface IProductService
    {
        string GetAppSetting(string key);
        string GetEnvironmentVariable(string key);
    }
}
