using System;
using System.Collections.Generic;
using CCTU.Entities;

namespace DAO.Entities.SIG
{
    public class Franquia : IBaseEntity<Guid>, IPessoaJuridica
    {
        // IBaseEntity<Guid> Implementation
        #region IBaseEntity<Guid>
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        #endregion

        //IPessoaJuridica Implementation
        #region IPessoaJuridica
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataFundacao { get; set; }
        #endregion

        public virtual List<TelefoneFranquia> Telefones { get; set; }
        public virtual List<EnderecoFranquia> Enderecos { get; set; }
        public virtual List<EmailFranquia> Emails { get; set; }
    }
}
