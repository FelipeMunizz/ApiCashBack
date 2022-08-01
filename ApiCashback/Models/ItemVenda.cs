using System.Text.Json.Serialization;

namespace ApiCashback.Models
{
    public class ItemVenda
    {
        public int ID { get; set; }
        public virtual Cerveja? Produto { get; set; }
        public decimal ValorCashBack { get; set; }

        public int VendaID { get; set; }

        [JsonIgnore]
        public virtual Venda? Venda { get; set; }
    }
}
