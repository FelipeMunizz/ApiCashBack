using ApiCashback.Data;
using ApiCashback.Models;
using CashBack.Repositories.Interfaces;

namespace CashBack.Repositories
{
    public class CatalogoCervejaRepository : ICatalogoCervejaRepository
    {
        private AppDbContext _context;

        public CatalogoCervejaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cerveja> ListarTodosPorMarca(string marca, int offset, int limit)
        {
            return _context.CatalogoCervejas.Where(x => x.Marca.Equals(marca)).OrderBy(o => o.Marca).Skip(offset).Take(limit).ToList();
        }

        public Cerveja ObterCervejaPorId(int id)
        {
            return _context.CatalogoCervejas.Where(x => x.ProdutoId.Equals(id)).FirstOrDefault();
        }
    }
}
