using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public partial class ApplicationDaoDbContext 
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
