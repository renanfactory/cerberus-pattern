using System;
using CCTU.Entities;
using DAO.Entities.Domains;

namespace DAO.Entities.SIG
{
    public class TelefoneFranquia : IBaseEntity<int>, ITelefone<TipoTelefone>
    {
        // IBaseEntity<int> Implementation
        #region IBaseEntity<int>
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        #endregion

        // ITelefone Implementation
        #region ITelefone
        public string CodigoPais { get; set; }
        public string CodigoRegiao { get; set; }
        public string Numero { get; set; }
        public string Ramal { get; set; }
        public bool Principal { get; set; }
        #endregion

        // ITelefone<TipoTelefone> Implementation
        #region ITelefone<TipoTelefone>
        public TipoTelefone TipoTelefone { get; set; }
        #endregion

        public virtual Franquia Proprietario { get; set; }
    }
}
