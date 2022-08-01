namespace ApiCashback.Repository.Interfaces
{
    public interface ICashbackPercentualRepository
    {
        decimal ObterCashBack(string genero);
        decimal ObterCashBack(string genero, DateTime dataVenda);
    }
}
