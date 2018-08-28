using System;
using CCTU.Entities;

namespace DAO.Entities.SIG
{
    public class EmailFuncionario : IBaseEntity<int>, IObjetoValor
    {
        // IBaseEntity<int> Implementation
        #region IBaseEntity<int>
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        #endregion

        public string Valor { get; set; }
        public bool Principal { get; set; }
        public virtual Funcionario Proprietario { get; set; }
    }
}
