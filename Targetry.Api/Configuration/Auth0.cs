using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Targetry.Api.AuthorizationHandler;

namespace Targetry.Api.Configuration
{
    public static class Auth0
    {
        public static IServiceCollection AddAuth0(this IServiceCollection services, IConfiguration configuration)
        {
            var domain = configuration["Auth0Settings:Domain"];
            var audience = configuration["Auth0Settings:Audience"];

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = domain;
                options.Audience = audience;
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("read:users", policy => policy.Requirements.Add(new HasScopeRequirement("read:users", domain!)));
                options.AddPolicy("write:users", policy => policy.Requirements.Add(new HasScopeRequirement("write:users", domain!)));
            });

            return services;
        }
    }
}
