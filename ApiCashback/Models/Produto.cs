using System.ComponentModel.DataAnnotations;

namespace ApiCashback.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string? Tipo { get; set; }
        public string? Marca { get; set; }
        public double PrecoVenda { get; set; }
    }
}
