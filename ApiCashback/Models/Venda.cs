using System.ComponentModel.DataAnnotations;

namespace ApiCashback.Models
{
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorTotalItens { get; set; }
        public double CashBackTotalVenda { get; set; }
        public virtual ICollection<ItemVenda>? Itens { get; set; }
    }
}
