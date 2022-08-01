using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCashback.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashbackPercentuais",
                columns: table => new
                {
                    CashbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domingo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Segunda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Terca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quarta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quinta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sexta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sabado = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashbackPercentuais", x => x.CashbackId);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoCervejas",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoCervejas", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorTotalItens = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashBackTotalVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.VendaId);
                });

            migrationBuilder.CreateTable(
                name: "ItensVendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(type: "int", nullable: true),
                    ValorCashBack = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VendaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensVendas_CatalogoCervejas_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "CatalogoCervejas",
                        principalColumn: "ProdutoId");
                    table.ForeignKey(
                        name: "FK_ItensVendas_Vendas_VendaID",
                        column: x => x.VendaID,
                        principalTable: "Vendas",
                        principalColumn: "VendaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_ProdutoId",
                table: "ItensVendas",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_VendaID",
                table: "ItensVendas",
                column: "VendaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashbackPercentuais");

            migrationBuilder.DropTable(
                name: "ItensVendas");

            migrationBuilder.DropTable(
                name: "CatalogoCervejas");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
