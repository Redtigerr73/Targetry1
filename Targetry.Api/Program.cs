using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Targetry.Api;
using Targetry.Api.AuthorizationHandler;
using Targetry.Api.Configuration;
using Targetry.Api.Exceptions;
using Targetry.Application;
using Targetry.Infrastructure;
using Microsoft.IdentityModel.Logging;
using static System.Net.WebRequestMethods;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        IdentityModelEventSource.ShowPII = true;

        var Configuration = builder.Configuration;

        // CORS configuration
        builder.Services.AddCorsConfiguration();

        // use the static method in the other DLL to inject what you need
        builder.Services.AddApplication();
        builder.Services.AddInfrastructure(Configuration);

        // Endpoints & GlobalException : to call ExceptionsFilter on each controller
        builder.Services.AddControllers(options => options.Filters.Add<ExceptionsFilter>());

        //API Versioning services 
        builder.Services.AddApiVersioning();
        builder.Services.AddApiVersioningExplorer();

        //Add Swagger Configuration
        builder.Services.AddSwaggerGenConfiguration();
        builder.Services.ConfigureOptions<SwaggerOptionsConfiguration>();

        //Add Authentication Configuration

        string domain = "https://dev-ku3jkm2v.us.auth0.com";

        builder.Services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
                options.Authority = domain;
                options.Audience = "https://localhost:7105/";
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = ClaimTypes.NameIdentifier
                };
            });

        builder.Services
            .AddAuthorization(
                options =>
            {
                options.AddPolicy(
                    "read:messages",
                    policy => policy.Requirements.Add(
                    new HasScopeRequirement("read:messages", domain)
                    )
                );
            });


        builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
        builder.Services.AddEndpointsApiExplorer();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
                // build a swagger endpoint for each discovered API version
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                }
            });
        }

        app.UseCors("CorsPolicy");

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}