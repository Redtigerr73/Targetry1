
namespace Targetry.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCorsConfiguration( this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    {
                        // TODO: Update if needed
                        builder.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                    });
            });

            return services;
        }
    }
}
