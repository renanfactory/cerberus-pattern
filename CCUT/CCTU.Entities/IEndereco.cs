namespace CCTU.Entities
{
    public interface IEndereco<TTipoEndereco> where TTipoEndereco : IObjetoValor
    {
        string Cep { get; set; }
        string Logradouro { get; set; }
        string Numero { get; set; }
        string Complemento { get; set; }
        string UF { get; set; }
        int Cidade { get; set; }
        bool Principal { get; set; }
        TTipoEndereco TipoEndereco { get; set; }
    }
}
