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
                    Domingo = table.Column<double>(type: "float", nullable: false),
                    Segunda = table.Column<double>(type: "float", nullable: false),
                    Terca = table.Column<double>(type: "float", nullable: false),
                    Quarta = table.Column<double>(type: "float", nullable: false),
                    Quinta = table.Column<double>(type: "float", nullable: false),
                    Sexta = table.Column<double>(type: "float", nullable: false),
                    Sabado = table.Column<double>(type: "float", nullable: false)
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
                    PrecoVenda = table.Column<double>(type: "float", nullable: false)
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
                    ValorTotalItens = table.Column<double>(type: "float", nullable: false),
                    CashBackTotalVenda = table.Column<double>(type: "float", nullable: false)
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
                    ValorCashBack = table.Column<double>(type: "float", nullable: false),
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

            migrationBuilder.InsertData(
                table: "CashbackPercentuais",
                columns: new[] { "CashbackId", "Domingo", "Marca", "Quarta", "Quinta", "Sabado", "Segunda", "Sexta", "Terca" },
                values: new object[,]
                {
                    { 1, 0.25, "Sokl", 0.02, 0.10000000000000001, 0.20000000000000001, 0.070000000000000007, 0.14999999999999999, 0.059999999999999998 },
                    { 2, 0.29999999999999999, "Brahma", 0.14999999999999999, 0.20000000000000001, 0.29999999999999999, 0.050000000000000003, 0.25, 0.10000000000000001 },
                    { 3, 0.34999999999999998, "Stella", 0.80000000000000004, 0.13, 0.25, 0.029999999999999999, 0.17999999999999999, 0.5 },
                    { 4, 0.40000000000000002, "Bohemia", 0.14999999999999999, 0.14999999999999999, 0.40000000000000002, 0.10000000000000001, 0.20000000000000001, 0.14999999999999999 }
                });

            migrationBuilder.InsertData(
                table: "CatalogoCervejas",
                columns: new[] { "ProdutoId", "Marca", "PrecoVenda", "Tipo" },
                values: new object[,]
                {
                    { 1, "Skol", 4.5800000000000001, "Cerveja" },
                    { 2, "Brahma", 5.3399999999999999, "Cerveja" },
                    { 3, "Stella", 6.79, "Cerveja" },
                    { 4, "Skol", 6.8399999999999999, "Cerveja" }
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
