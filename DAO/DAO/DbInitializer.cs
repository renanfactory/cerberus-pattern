using System;
using System.Threading.Tasks;
using DAO.Entities.Domains;

namespace DAO
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDaoDbContext _context;

        public DbInitializer(ApplicationDaoDbContext context)
        {
            _context = context;
        }

        public async Task Initialize()
        {
            await _context.Database.EnsureCreatedAsync();

            // Seed - Tipos de Endereço
            await _context.TblTiposEnderecos.AddAsync(new TipoEndereco { Situacao = "Ativo", Valor = "Residencial", DataCriacao = DateTime.Now });
            await _context.TblTiposEnderecos.AddAsync(new TipoEndereco { Situacao = "Ativo", Valor = "Comercial", DataCriacao = DateTime.Now });

            // Seed - Tipos de Telefone
            await _context.TblTiposTelefones.AddAsync(new TipoTelefone { Situacao = "Ativo", Valor = "Residencial", DataCriacao = DateTime.Now });
            await _context.TblTiposTelefones.AddAsync(new TipoTelefone { Situacao = "Ativo", Valor = "Comercial", DataCriacao = DateTime.Now });
            await _context.TblTiposTelefones.AddAsync(new TipoTelefone { Situacao = "Ativo", Valor = "Celular", DataCriacao = DateTime.Now });
            
            await _context.SaveChangesAsync();
        }
    }
}
