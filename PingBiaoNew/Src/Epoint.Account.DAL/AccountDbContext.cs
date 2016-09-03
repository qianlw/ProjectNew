using System;
using Epoint.Framework.DAL;
using Epoint.Core.Config;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using Epoint.Account.Contract;
using Epoint.Core.Log;

namespace Epoint.Account.DAL
{
    public class AccountDbContext : DbContextBase
    {
        public AccountDbContext()
            : base("Account", new LogDbContext())
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<AccountDbContext>(null);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Roles)
                .WithMany(e => e.Users)
                .Map(m =>
                {
                    m.ToTable("UserRole");
                    m.MapLeftKey("UserID");
                    m.MapRightKey("RoleID");
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<LoginInfo> LoginInfos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<VerifyCode> VerifyCodes { get; set; }
    }
}
