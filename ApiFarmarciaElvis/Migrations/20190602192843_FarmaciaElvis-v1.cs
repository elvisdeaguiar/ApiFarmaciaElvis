using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFarmarciaElvis.Migrations
{
    public partial class FarmaciaElvisv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UltimaChanceProduto",
                columns: table => new
                {
                    ULCH_SQ_PRODUTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FILI_CD_FILIAL = table.Column<int>(nullable: false),
                    PRME_CD_PRODUTO = table.Column<int>(nullable: false),
                    ULCH_QUANTIDADE = table.Column<int>(nullable: false),
                    ULCH_LOTE = table.Column<string>(maxLength: 50, nullable: false),
                    ULCH_DT_VENCIMENTO = table.Column<DateTime>(nullable: false),
                    ULCH_FL_AUTORIZADO = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UltimaChanceProduto", x => x.ULCH_SQ_PRODUTO);
                });

            migrationBuilder.CreateTable(
                name: "UltimaChanceAutorizacao",
                columns: table => new
                {
                    ULCH_SQ_AUTORIZACAO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ULCH_SQ_PRODUTO = table.Column<int>(nullable: false),
                    ULCH_CD_BARRAS = table.Column<string>(maxLength: 20, nullable: false),
                    ULCH_FL_SITUACAO = table.Column<string>(maxLength: 1, nullable: false),
                    ULCH_DH_VENDA = table.Column<DateTime>(nullable: true),
                    ULCH_MENOR_PRECO = table.Column<decimal>(nullable: true),
                    ULCH_PRECO_VENDA = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UltimaChanceAutorizacao", x => x.ULCH_SQ_AUTORIZACAO);
                    table.ForeignKey(
                        name: "FK_UltimaChanceAutorizacao_UltimaChanceProduto_ULCH_SQ_PRODUTO",
                        column: x => x.ULCH_SQ_PRODUTO,
                        principalTable: "UltimaChanceProduto",
                        principalColumn: "ULCH_SQ_PRODUTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UltimaChanceAutorizacao_ULCH_SQ_PRODUTO",
                table: "UltimaChanceAutorizacao",
                column: "ULCH_SQ_PRODUTO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UltimaChanceAutorizacao");

            migrationBuilder.DropTable(
                name: "UltimaChanceProduto");
        }
    }
}
