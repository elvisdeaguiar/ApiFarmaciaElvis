using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFarmarciaElvis.Migrations
{
    public partial class FarmaciaElvisv2AjustesPropriedadesNotNullDaClasseUltimaChanceAutorizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ULCH_PRECO_VENDA",
                table: "UltimaChanceAutorizacao",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ULCH_MENOR_PRECO",
                table: "UltimaChanceAutorizacao",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ULCH_DH_VENDA",
                table: "UltimaChanceAutorizacao",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ULCH_PRECO_VENDA",
                table: "UltimaChanceAutorizacao",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "ULCH_MENOR_PRECO",
                table: "UltimaChanceAutorizacao",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ULCH_DH_VENDA",
                table: "UltimaChanceAutorizacao",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
