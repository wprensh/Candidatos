namespace PruebaTecnicaLibrary.Vo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PruebaTecnicaDb : DbContext
    {
        public PruebaTecnicaDb()
            : base("name=PruebaTecnicaDb")
        {
        }

        public virtual DbSet<Entrevista> Entrevistas { get; set; }
        public virtual DbSet<Reclutadore> Reclutadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reclutadore>()
                .HasMany(e => e.Entrevistas)
                .WithRequired(e => e.Reclutadore)
                .HasForeignKey(e => e.Reclutador)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<PruebaTecnicaLibrary.Vo.TipoTecnologia> TipoTecnologias { get; set; }
    }
}
