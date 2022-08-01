using ApiCashback.Data;
using CashBack.Repositories.Interfaces;

namespace CashBack.Repositories
{
    public class CashBackPercentualRepository : ICashBackPercentualRepository
    {
        private AppDbContext _context;

        public CashBackPercentualRepository(AppDbContext context)
        {
            _context = context;
        }

        public decimal ObterCashback(string marca)
        {
            decimal valor = 0;
            int diaDaSemana = (int)DateTime.Now.DayOfWeek;
            if (!string.IsNullOrWhiteSpace(marca))
            {
                var cash = _context.CashbackPercentuais.Where(c => c.Marca.Equals(marca)).FirstOrDefault();
                
                if (cash != null)
                {
                    switch(diaDaSemana)
                    {
                        case 0:
                            valor = cash.Domingo;
                            break;
                        case 1:
                            valor = cash.Segunda;
                            break;
                        case 2:
                            valor = cash.Terca;
                            break;
                        case 3:
                            valor = cash.Quarta;
                            break;
                        case 4:
                            valor = cash.Quinta;
                            break;
                        case 5:
                            valor = cash.Sexta;
                            break;
                        case 6:
                            valor = cash.Sabado;
                            break;                        
                    }
                }
            }
            return valor;
        }

        public decimal ObterCashback(string marca, DateTime dataVenda)
        {
            decimal valor = 0;
            int diaDaSemana = (int)dataVenda.DayOfWeek;
            if (!string.IsNullOrWhiteSpace(marca))
            {
                var cash = _context.CashbackPercentuais.Where(c => c.Marca.Equals(marca)).FirstOrDefault();

                if (cash != null)
                {
                    switch (diaDaSemana)
                    {
                        case 0:
                            valor = cash.Domingo;
                            break;
                        case 1:
                            valor = cash.Segunda;
                            break;
                        case 2:
                            valor = cash.Terca;
                            break;
                        case 3:
                            valor = cash.Quarta;
                            break;
                        case 4:
                            valor = cash.Quinta;
                            break;
                        case 5:
                            valor = cash.Sexta;
                            break;
                        case 6:
                            valor = cash.Sabado;
                            break;                        
                    }
                }
            }
            return valor;
        }
    }
}
