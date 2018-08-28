using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAO
{
    public class ApplicationDaoDbContextFactory : IDesignTimeDbContextFactory<ApplicationDaoDbContext>
    {
        public ApplicationDaoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDaoDbContext>();
            optionsBuilder.UseSqlite("Data Source=.\\IdentityDB.db;");
            return new ApplicationDaoDbContext(optionsBuilder.Options);
        }
    }
}