
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data.Model;

namespace Ipreo.NS.Permissions.Data.Repository.DataContext
{
    public  class UsersContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger _logger;

        public virtual DbSet<UsersRecord> Users { get; set; }

      public  UsersContext()
        {

        }
       //protected UsersContext( DbContextOptions<UsersContext> options) : base(options)
       // {
       //     //_loggerFactory = loggerFactory;
       //     //_logger = loggerFactory.CreateLogger(nameof(UsersContext));
       // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
                base.OnConfiguring(optionsBuilder);

                if (!optionsBuilder.IsConfigured)
                {

                   
                        var connectionString = "Data Source=.;Initial Catalog=TTUserManagement;Integrated Security=True;Pooling=False";
                        optionsBuilder.UseSqlServer(connectionString);
                   
                    //optionsBuilder.UseLoggerFactory(_loggerFactory);
                    //optionsBuilder.EnableSensitiveDataLogging();
                }
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsersRecord>().HasKey(c => new { c.Id });
           

        }
    }
}
