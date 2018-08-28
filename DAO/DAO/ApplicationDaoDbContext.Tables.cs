using DAO.Entities.Domains;
using DAO.Entities.SIG;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public partial class ApplicationDaoDbContext
    {
        #region Tables 

        #region Dominios
        
        public DbSet<TipoEndereco> TblTiposEnderecos { get; set; }
        public DbSet<TipoTelefone> TblTiposTelefones { get; set; }

        #endregion

        #region SIG

        public DbSet<Funcionario> TblFuncionarios { get; set; }
        public DbSet<TelefoneFuncionario> TblTelefoneFuncionarios { get; set; }
        public DbSet<EnderecoFuncionario> TblEnderecoFuncionario { get; set; }

        #endregion
        
        #endregion
    }
}
