namespace CCTU.Entities
{
    public interface ITelefone<TTipoTelefone> where TTipoTelefone: IObjetoValor
    {
        string CodigoPais { get; set; }
        string CodigoRegiao { get; set; }
        string Numero { get; set; }
        string Ramal { get; set; }
        bool Principal { get; set; }
        TTipoTelefone TipoTelefone { get; set; }
    }
}
