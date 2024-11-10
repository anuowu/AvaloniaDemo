using Microsoft.Extensions.DependencyInjection;

namespace Bee;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        return services;
    }  

}