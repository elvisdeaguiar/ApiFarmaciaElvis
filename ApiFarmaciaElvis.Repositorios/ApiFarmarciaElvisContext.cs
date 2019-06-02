using Microsoft.EntityFrameworkCore;
using ApiFarmaciaElvis.Entidades;

namespace ApiFarmarciaElvis.Repositorios
{
    public class ApiFarmarciaElvisContext : DbContext
    {
        public ApiFarmarciaElvisContext (DbContextOptions<ApiFarmarciaElvisContext> options)
            : base(options)
        {
        }

        public DbSet<ApiFarmaciaElvis.Entidades.UltimaChanceProduto> UltimaChanceProduto { get; set; }

        public DbSet<ApiFarmaciaElvis.Entidades.UltimaChanceAutorizacao> UltimaChanceAutorizacao { get; set; }
    }
}
