using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Targetry.Application.Common.Interfaces;
using Targetry.Infrastructure.Persistence;
using Targetry.Infrastructure.Repositories;

namespace Targetry.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TargetryContext>(options => //Configuration of the connection string
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                   action => action.MigrationsAssembly(typeof(TargetryContext).Assembly.FullName)));

            services.AddScoped<ITargetryDbContext, TargetryContext>(); //AddScoped to declare DI for every query or request a new instance of DbContext will be used (to avoid errors or exceptions) 

            services.AddScoped<IUserRepository, UserRepository>(); // TODO : Don't forget to inject the repositories 
            
            return services;
        }
    }


}
