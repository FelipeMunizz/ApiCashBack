using ApiCashback.Services.Interfaces;
using CashBack.Repositories.Interfaces;

namespace CashBack.Services
{
    public class CashBackPercentualService : ICashBackPercentualService
    {
        private readonly ICashBackPercentualRepository _cashBackPercentualRepository;

        public CashBackPercentualService(ICashBackPercentualRepository cashBackPercentualRepository)
        {
            _cashBackPercentualRepository = cashBackPercentualRepository;
        }

        public double ObterCashback(string marca)
        {
            return _cashBackPercentualRepository.ObterCashback(marca);
        }
    }
}
