using System;

namespace CCTU.Entities
{
    public interface IPessoaJuridica
    {
        /// <summary>
        /// CNPJ da Empresa
        /// </summary>
        string CNPJ { get; set; }

        /// <summary>
        /// Nome da Empresa
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Nome fantasia da Empresa
        /// </summary>
        string NomeFantasia { get; set; }

        /// <summary>
        /// Inscrição municipal da empresa
        /// </summary>
        string InscricaoEstadual { get; set; }

        /// <summary>
        /// Data de fundação da empresa
        /// </summary>
        DateTime DataFundacao {get;set;}
    }
}
