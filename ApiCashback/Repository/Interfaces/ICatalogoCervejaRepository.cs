using ApiCashback.Models;

namespace CashBack.Repositories.Interfaces
{
    public interface ICatalogoCervejaRepository
    {
        IEnumerable<Produto> ListarTodosPorMarca(string marca, int offset, int limit);
        Produto ObterCervejaPorId(int id);
    }
}
