using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public partial class ApplicationDaoDbContext : DbContext
    {
        public ApplicationDaoDbContext(DbContextOptions<ApplicationDaoDbContext> options)
            : base(options) { }


    }
}
