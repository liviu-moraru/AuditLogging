using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Skoruba.AuditLogging.EntityFramework.DbContexts.Default;

namespace Skoruba.AuditLogging.EntityFramework
{
    public class ContextFactory : IDesignTimeDbContextFactory<DefaultAuditLoggingDbContext>
    {
        public DefaultAuditLoggingDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<DefaultAuditLoggingDbContext>()
                .UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=AuditDB;Trusted_Connection=True;MultipleActiveResultSets=true"
    
                )
                .Options;
            return new DefaultAuditLoggingDbContext(options);
        }
    }
}