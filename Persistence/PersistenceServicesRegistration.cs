using Application.Abstractions.Services;
using Application.IRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;
using Persistence.Services;

namespace Persistence;

public static class PersistenceServicesRegistration
{
     public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
     {
          #region Microsoft SQL Server

          services.AddDbContext<ECommerceDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

          #endregion

          #region Microsoft.AspNetCore.Identity

          services.AddIdentity<AppUser, AppRole>(options =>
          {
               options.Password.RequiredLength = 8;
               options.Password.RequireNonAlphanumeric = false;
               options.Password.RequireDigit = false;
               options.Password.RequireLowercase = false;
               options.Password.RequireUppercase = false;
               options.Password.RequiredUniqueChars = 0;

               options.User.RequireUniqueEmail = true;
          }).AddEntityFrameworkStores<ECommerceDbContext>();

          #endregion

          #region Repositories

          services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));





   

          #endregion

          #region Services

          services.AddScoped<IAuthService, AuthService>();

          #endregion

          return services;
     }
}
