using ApiCashback.Models;

namespace ApiCashback.Services.Interfaces
{
    public interface ICatalogoCervejaService
    {
        IEnumerable<Produto> ListarTodosPorMarca(string marca, int offset, int limit);
        Produto ObterCervejaPorId(int id);
    }
}
