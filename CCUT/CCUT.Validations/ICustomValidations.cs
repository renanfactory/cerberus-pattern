namespace CCUT.Validations
{
    public interface ICustomValidations
    {
        bool IsValidCPF(string cpf);
        bool isValidCNPJ(string cnpj);
        bool isValidRG(string rg);
        bool isValidPis(string pis);
    }
}
