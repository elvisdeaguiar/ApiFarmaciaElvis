using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFarmarciaElvis.Migrations
{
    public partial class FarmaciaElvisv3AjustesEntidadeUltimaChanceAutorizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ULCH_FL_TIPO_PRODUTO",
                table: "UltimaChanceAutorizacao",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ULCH_PERCENTUAL_DESCONTO",
                table: "UltimaChanceAutorizacao",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ULCH_FL_TIPO_PRODUTO",
                table: "UltimaChanceAutorizacao");

            migrationBuilder.DropColumn(
                name: "ULCH_PERCENTUAL_DESCONTO",
                table: "UltimaChanceAutorizacao");
        }
    }
}
