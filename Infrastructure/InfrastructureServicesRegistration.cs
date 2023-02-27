using Application.Abstractions.JWT;
using Application.Abstractions.Storage;
using Infrastructure.Services.JWT;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServicesRegistration
{
     public static void ConfigureInfrastructureServices(this IServiceCollection services)
     {
          services.AddScoped<ITokenHandler, TokenHandler>();
     }

     public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : class, IStorage
     {
          serviceCollection.AddScoped<IStorage, T>();
     }

 
}
