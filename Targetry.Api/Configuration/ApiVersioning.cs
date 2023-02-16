using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace Targetry.Api.Configuration
{
    public static class ApiVersioning
    {
        public static IServiceCollection AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                //To display current version to the user
                options.ReportApiVersions = true;
                //To put as default if unspecified v1.0
                options.AssumeDefaultVersionWhenUnspecified = true;
                //Specifies default Api version
                options.DefaultApiVersion = new ApiVersion(1, 0);
                //How we read the versioning - Multiple way to read
                options.ApiVersionReader = ApiVersionReader.Combine(
                    // As a query
                    new QueryStringApiVersionReader("api-version"),
                    // As a header
                    new HeaderApiVersionReader("api-version"),
                    // As a mediaType
                    new MediaTypeApiVersionReader("ver"),
                    // As an Segment extracted from URL
                    new UrlSegmentApiVersionReader());
            });
            return services;
        }
    }
}
