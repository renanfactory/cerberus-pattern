using System;
using System.Collections.Generic;
using CCTU.Entities;

namespace DAO.Entities.SIG
{
    public class Funcionario : IBaseEntity<Guid>, IPessoaFisica, IFuncionario
    {
        // IBaseEntity<Guid> Implementation
        #region IBaseEntity<Guid>
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        #endregion

        // IPessoaFisica Implementation
        #region IPessoaFisica
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        #endregion

        // IFuncionario Implementation
        #region IFuncionario
        public string Cargo { get; set; }
        public string HorarioEntrada { get; set; }
        public string HorarioSaida { get; set; }
        #endregion

        public virtual List<TelefoneFuncionario> Telefones { get; set; }
        public virtual List<EnderecoFuncionario> Enderecos { get; set; }
        public virtual List<EmailFuncionario> Emails { get; set; }
    }
}
