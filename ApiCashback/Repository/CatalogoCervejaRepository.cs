using ApiCashback.Data;
using ApiCashback.Models;
using ApiCashback.Repository.Interfaces;

namespace ApiCashback.Repository
{
    public class CatalogoCervejaRepository : ICatalogoCervejaRepository
    {
        private AppDbContext _context;

        public CatalogoCervejaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cerveja> GetTodosPorNome(string nome, int offset, int limit)
        {
            return _context.CatalogoCervejas.Where(x => x.Nome.Equals(nome)).OrderBy(o => o.Nome).Skip(offset).Take(limit).ToList();
        }

        public Cerveja GetCervejaPorID(int id)
        {
            return _context.CatalogoCervejas.Where(x => x.ProdutoID.Equals(id)).FirstOrDefault();
        }
    }
}
