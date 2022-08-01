using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashBack.Repositories.Interfaces
{
    public interface ICashBackPercentualRepository
    {
        double ObterCashback(string marca);
        double ObterCashback(string marca, DateTime dataVenda);
    }
}
