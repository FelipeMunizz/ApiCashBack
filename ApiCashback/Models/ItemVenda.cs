using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiCashback.Models
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }
        public virtual Produto? Produto { get; set; }
        public double ValorCashBack { get; set; }

        public int VendaID { get; set; }

        [JsonIgnore]
        public virtual Venda? Venda { get; set; }
    }
}
