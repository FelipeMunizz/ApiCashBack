using ApiCashback.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCashback.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

    public DbSet<Cerveja> CatalogoCervejas { get; set; }
    public DbSet<CashbackPercentual> CashbackPercentuais { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<ItemVenda> ItensVendas { get; set; }
}
