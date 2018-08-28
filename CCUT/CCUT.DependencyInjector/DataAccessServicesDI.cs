using DAO;
using DAO.Cep;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CCUT.DependencyInjector
{
    public static class DataAccessServicesDI
    {
        public static void ConfigureContextService(this IServiceCollection services,IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDaoDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ApplicationCepDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("CepConnection")));
            
            services.AddTransient<IDbInitializer, DbInitializer>();
        }
    }
}
