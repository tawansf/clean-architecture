using CleanArc.Application.Abstractions;
using CleanArc.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        => services.AddServices().AddDatabase(configuration);

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Your services here
        return services;
    }

    private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("YourDatabaseHere");
        services.AddDbContext<ApplicationDbContext>(o =>
        {
            o.UseSqlServer(connectionString, mssqlOpts =>
            {
                mssqlOpts.MigrationsHistoryTable(HistoryRepository.DefaultTableName, Schemas.Default);
            });
        });
        
        services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<ApplicationDbContext>());

        return services;
    }

    private static IServiceCollection AddAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    private static IServiceCollection AddAuthorization(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
