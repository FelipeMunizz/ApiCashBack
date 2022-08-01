using ApiCashback.Models;

namespace ApiCashback.Repository.Interfaces
{
    public interface ICatalogoCervejaRepository
    {
        IEnumerable<Cerveja> GetTodosPorNome(string nome, int offset, int limit) ;
        Cerveja GetCervejaPorID(int id);
    }
}
