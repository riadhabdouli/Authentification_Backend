using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class SignalRServicesRegistration
{
     public static void ConfigureSignalRServices(this IServiceCollection services)
     {
          services.AddSignalR();

          //return services;
     }
}
