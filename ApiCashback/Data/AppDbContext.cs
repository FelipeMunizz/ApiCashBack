using ApiCashback.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCashback.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Produto> CatalogoCervejas { get; set; }
    public DbSet<CashbackPercentual> CashbackPercentuais { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<ItemVenda> ItensVendas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasData(
            new Produto
            {
                ProdutoId = 1,
                Tipo = "Cerveja",
                Marca = "Skol",
                PrecoVenda = 4.58
            },
            new Produto
            {
                ProdutoId = 2,
                Tipo = "Cerveja",
                Marca = "Brahma",
                PrecoVenda = 5.34
            },
            new Produto
            {
                ProdutoId = 3,
                Tipo = "Cerveja",
                Marca = "Stella",
                PrecoVenda = 6.79
            },
            new Produto
            {
                ProdutoId = 4,
                Tipo = "Cerveja",
                Marca = "Skol",
                PrecoVenda = 6.84
            }
        );
        modelBuilder.Entity<CashbackPercentual>().HasData(
            new CashbackPercentual
            {
                CashbackId = 1,
                Marca = "Sokl",
                Domingo = 0.25,
                Segunda = 0.07,
                Terca = 0.06,
                Quarta = 0.02,
                Quinta = 0.10,
                Sexta = 0.15,
                Sabado = 0.20
            },
        new CashbackPercentual
        {
            CashbackId = 2,
            Marca = "Brahma",
            Domingo = 0.30,
            Segunda = 0.05,
            Terca = 0.10,
            Quarta = 0.15,
            Quinta = 0.20,
            Sexta = 0.25,
            Sabado = 0.30
        },
        new CashbackPercentual
        {
            CashbackId = 3,
            Marca = "Stella",
            Domingo = 0.35,
            Segunda = 0.03,
            Terca = 0.5,
            Quarta = 0.8,
            Quinta = 0.13,
            Sexta = 0.18,
            Sabado = 0.25
        },
        new CashbackPercentual
        {
            CashbackId = 4,
            Marca = "Bohemia",
            Domingo = 0.40,
            Segunda = 0.10,
            Terca = 0.15,
            Quarta = 0.15,
            Quinta = 0.15,
            Sexta = 0.20,
            Sabado = 0.40
        }
        );
    }
}
