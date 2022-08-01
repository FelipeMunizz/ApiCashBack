using ApiCashback.Models;
using ApiCashback.Services.Interfaces;
using CashBack.Repositories.Interfaces;

namespace CashBack.Services
{
    public class CatalogoCervejaService : ICatalogoCervejaService
    {
        private ICatalogoCervejaRepository _catalogoRepository;

        public CatalogoCervejaService(ICatalogoCervejaRepository catalogo)
        {
            _catalogoRepository = catalogo;
        }
        public IEnumerable<Cerveja> ListarTodosPorMarca(string genero, int offset, int limit)
        {
            return _catalogoRepository.ListarTodosPorMarca(genero, offset, limit);
        }

        public Cerveja ObterCervejaPorId(int id)
        {
            return _catalogoRepository.ObterCervejaPorId(id);
        }
    }
}
