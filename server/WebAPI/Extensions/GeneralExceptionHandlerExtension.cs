using Microsoft.AspNetCore.Builder;
using ProjectStructureHW.ExceptionsMiddleware;

namespace ProjectStructureHW.Extensions
{
    public static class GeneralExceptionHandlerExtension
    {
        public static IApplicationBuilder ConfigureCustomExceptionHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
