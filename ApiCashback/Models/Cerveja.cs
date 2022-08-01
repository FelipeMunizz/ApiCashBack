using System.ComponentModel.DataAnnotations;

namespace ApiCashback.Models
{
    public class Cerveja
    {
        [Key]
        public int ProdutoId { get; set; }
        public string? Tipo { get; set; }
        public string? Marca { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
