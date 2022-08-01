﻿using ApiCashback.Models;

namespace CashBack.Repositories.Interfaces
{
    public interface ICatalogoCervejaRepository
    {
        IEnumerable<Cerveja> ListarTodosPorMarca(string marca, int offset, int limit);
        Cerveja ObterCervejaPorId(int id);
    }
}
