using System;

namespace CCTU.Entities
{
    public interface IPessoaFisica
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }
        DateTime DataNascimento { get; set; }
        string CPF { get; set; }
        string CNPJ { get; set; }
    }
}
