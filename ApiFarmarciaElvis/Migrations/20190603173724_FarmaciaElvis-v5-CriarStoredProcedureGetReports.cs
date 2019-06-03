using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;
using System.Reflection;

namespace ApiFarmarciaElvis.Migrations
{
    public partial class FarmaciaElvisv5CriarStoredProcedureGetReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var nomeRecursoScript = typeof(FarmaciaElvisv5CriarStoredProcedureGetReports).Namespace + ".FarmaciaElvisv5CriarStoredProcedureGetReports.sql";

            string conteudoScript = "";
            using (Stream stream = assembly.GetManifestResourceStream(nomeRecursoScript))
            using (StreamReader reader = new StreamReader(stream))
            {
                conteudoScript = reader.ReadToEnd();
            }
            
            migrationBuilder.Sql(conteudoScript);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
