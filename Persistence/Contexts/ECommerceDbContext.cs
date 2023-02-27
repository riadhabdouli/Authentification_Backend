using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence.Contexts;

public class ECommerceDbContext : IdentityDbContext<AppUser, AppRole, int>
{
     public ECommerceDbContext() { }
     public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }

     #region Entities


     public DbSet<BaseFile> BaseFiles { get; set; }
  

     #endregion

     #region Customized SaveChangesAsync

     public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
     {
          foreach (var entry in ChangeTracker.Entries<BaseEntity>())
          {
               switch (entry.State)
               {
                    case EntityState.Added:
                         entry.Entity.CreatedDate = DateTime.Now;

                         break;
                    case EntityState.Modified:
                         entry.Entity.LastModifiedDate = DateTime.Now;
                         break;
               }
          }
          return base.SaveChangesAsync(cancellationToken);
     }

     #endregion

     #region OnModelCreating

     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
 
          modelBuilder.ApplyConfiguration(new AppUserConfiguration());
          modelBuilder.ApplyConfiguration(new AppRoleConfiguration());


          base.OnModelCreating(modelBuilder);
     }

     #endregion

}
