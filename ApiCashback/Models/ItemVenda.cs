using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiCashback.Models
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }
        public virtual Cerveja? Produto { get; set; }
        public decimal ValorCashBack { get; set; }

        public int VendaID { get; set; }

        [JsonIgnore]
        public virtual Venda? Venda { get; set; }
    }
}
