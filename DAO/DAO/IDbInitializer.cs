using System.Threading.Tasks;

namespace DAO
{
    public interface IDbInitializer
    {
        Task Initialize();
    }
}
