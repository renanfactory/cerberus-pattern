using Microsoft.EntityFrameworkCore;

namespace DAO.Cep
{
    public partial class ApplicationCepDbContext : DbContext
    {
        public ApplicationCepDbContext(DbContextOptions<ApplicationCepDbContext> options)
            : base(options) { }


    }
}
