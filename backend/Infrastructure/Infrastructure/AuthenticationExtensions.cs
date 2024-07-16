using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class AuthenticationExtensions
{
    public static IServiceCollection AddAuthenticationJWT(this IServiceCollection services)
    {

        return services;
    }
}
