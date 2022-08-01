using System.ComponentModel.DataAnnotations;

namespace ApiCashback.Models
{
    public class CashbackPercentual
    {
        [Key]
        public int CashbackId { get; set; }
        public string? Marca { get; set; }
        public double Domingo { get; set; }
        public double Segunda { get; set; }
        public double Terca { get; set; }
        public double Quarta { get; set; }
        public double Quinta { get; set; }
        public double Sexta { get; set; }
        public double Sabado { get; set; }
    }
}
