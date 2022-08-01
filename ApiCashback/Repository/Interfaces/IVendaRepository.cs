using ApiCashback.Models;

namespace ApiCashback.Repository.Interfaces
{
    public interface IVendaRepository
    {
        Venda ObterVendaPorId(int id);
        IEnumerable<Venda> ObterTodasVendas(DateTime dataInicial, DateTime dataFinal, int offset, int limit);
        Resultado IncluirVenda(Venda venda);
    }
}
