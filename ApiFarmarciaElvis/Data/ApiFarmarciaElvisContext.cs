using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiFarmarciaElvis.Repositorios
{
    public class ApiFarmarciaElvisContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();
            }
        }

        public ApiFarmarciaElvisContext (DbContextOptions<ApiFarmarciaElvisContext> options)
            : base(options)
        {
        }

        public DbSet<ApiFarmaciaElvis.Entidades.UltimaChanceProduto> UltimaChanceProduto { get; set; }

        public DbSet<ApiFarmaciaElvis.Entidades.UltimaChanceAutorizacao> UltimaChanceAutorizacao { get; set; }
    }
}