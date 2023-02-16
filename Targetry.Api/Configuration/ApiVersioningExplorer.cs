using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targetry.Api.Configuration
{
    public static class ApiVersioningExplorer
    {
        public static IServiceCollection AddApiVersioningExplorer(this IServiceCollection services)
        {
            services.AddVersionedApiExplorer(options =>
            {
                // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
                // note: the specified format code will format the version as "'v'major[.minor][-status]"
                //check https://github.com/dotnet/aspnet-api-versioning/wiki/Version-Format for more details about VVV
                options.GroupNameFormat = "'v'VVV";

                // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                // can also be used to control the format of the API version in route templates
                options.SubstituteApiVersionInUrl = true;
            });
            return services;
        }
    }
}
