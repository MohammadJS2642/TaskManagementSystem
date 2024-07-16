using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DatabaseConnection
{
    public static IServiceCollection GetDatabaseConnection(
        this IServiceCollection services,
        Action<DbContextOptionsBuilder>? contextOptions
    )
    {
        services.AddDbContext<TaskManagementDBContext>(contextOptions);
        return services;
    }
}
