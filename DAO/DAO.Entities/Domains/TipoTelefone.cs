using System;
using CCTU.Entities;

namespace DAO.Entities.Domains
{
    public class TipoTelefone : IBaseEntity<int>, IObjetoValor
    {
        // IBaseEntity<int> Implementation
        #region IBaseEntity<int>
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        #endregion

        // IObjetoValor Implementation
        #region IObjetoValor
        public string Valor { get; set; }
        #endregion
    }
}
