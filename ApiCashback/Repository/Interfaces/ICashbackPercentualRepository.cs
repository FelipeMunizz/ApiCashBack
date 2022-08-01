using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashBack.Repositories.Interfaces
{
    public interface ICashBackPercentualRepository
    {
        decimal ObterCashback(string marca);
        decimal ObterCashback(string marca, DateTime dataVenda);
    }
}
