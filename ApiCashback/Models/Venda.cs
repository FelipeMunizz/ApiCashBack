using System.ComponentModel.DataAnnotations;

namespace ApiCashback.Models
{
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotalItens { get; set; }
        public decimal CashBackTotalVenda { get; set; }
        public virtual ICollection<ItemVenda>? Itens { get; set; }
    }
}
