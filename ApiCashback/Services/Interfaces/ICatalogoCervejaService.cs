using ApiCashback.Models;

namespace ApiCashback.Services.Interfaces
{
    public interface ICatalogoCervejaService
    {
        IEnumerable<Cerveja> ListarTodosPorMarca(string marca, int offset, int limit);
        Cerveja ObterCervejaPorId(int id);
    }
}
