﻿using System.ComponentModel.DataAnnotations;

namespace ApiCashback.Models
{
    public class CashbackPercentual
    {
        [Key]
        public int CashbackId { get; set; }
        public string? Marca { get; set; }
        public decimal Domingo { get; set; }
        public decimal Segunda { get; set; }
        public decimal Terca { get; set; }
        public decimal Quarta { get; set; }
        public decimal Quinta { get; set; }
        public decimal Sexta { get; set; }
        public decimal Sabado { get; set; }
    }
}
