using ApiCashback.Data;
using ApiCashback.Models;
using CashBack.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CashBack.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private AppDbContext _context;
        private ICashBackPercentualRepository _cashBackRepository;
        private ICatalogoCervejaRepository _catalogo;

        public VendaRepository(AppDbContext contexto, ICashBackPercentualRepository cashBackRepository, ICatalogoCervejaRepository catalogo)
        {
            _context = contexto;
            _cashBackRepository = cashBackRepository;
            _catalogo = catalogo;
        }

        public Resultado IncluirVenda(Venda venda)
        {
            Resultado resultado = DadosValidos(venda);
            resultado.Acao = "Inclusão de Venda";

            if (resultado.Inconsistencias.Count == 0)
            {
                venda.DataVenda = DateTime.Now;

                _context.Vendas.Add(venda);
                
                

                foreach (var item in venda.Itens)
                {
                    item.VendaID = venda.VendaId;
                    
                    // Busca valor do CashBack
                    double valorPercentualCash = _cashBackRepository.ObterCashback(item.Produto.Marca);
                    item.ValorCashBack = item.Produto.PrecoVenda * valorPercentualCash;
                    item.Produto = _catalogo.ObterCervejaPorId(item.Produto.ProdutoId);

                    _context.ItensVendas.Add(item);
                    _context.Entry(item.Produto).State = EntityState.Unchanged;
                }

                if (venda.Itens != null && venda.Itens.Any())
                {
                    venda.CashBackTotalVenda = venda.Itens.Sum(x => x.ValorCashBack);
                    venda.ValorTotalItens = venda.Itens.Sum(x => x.Produto.PrecoVenda);
                    _context.SaveChanges();
                }

                
            }


            return resultado;
        }

        public IEnumerable<Venda> ObterTodasVendas(DateTime dataInicial, DateTime dataFinal, int offset, int limit)
        {
            IEnumerable<Venda> vendas = _context.Vendas
                .Where(x=>x.DataVenda.Date >= dataInicial.Date && x.DataVenda.Date <= dataFinal.Date)
                .Skip(offset)
                .Take(limit)
                .OrderByDescending(x=>x.DataVenda).ToList();                        
            return vendas;
        }

        public Venda ObterVendaPorId(int id)
        {
            return _context.Vendas.Where(x => x.VendaId.Equals(id)).FirstOrDefault();
        }

        private Resultado DadosValidos(Venda venda)
        {
            Resultado resultado = new Resultado();
            if (venda == null)
            {
                resultado.Inconsistencias.Add("Dados de venda inválido");
            }
            else
            {
                if (venda.Itens == null || !venda.Itens.Any())
                {
                    resultado.Inconsistencias.Add("Não é permitido inserir uma venda sem nenhum disco selecionado");
                }
            }

            return resultado;
        }
    }
}
