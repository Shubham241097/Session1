namespace Session1.ExceptionHandling
{
    public class ExceptionMiddleWare 
    {
        private readonly RequestDelegate _requestDelegate;

        public ExceptionMiddleWare(RequestDelegate requestDelegate) 
        {
            _requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an appropriate response
            }
        }
    }
}
