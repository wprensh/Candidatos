namespace PruebaTecnicaLibrary.Vo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tecnologia_Tbl.Reclutadores")]
    public partial class Reclutadore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reclutadore()
        {
            Entrevistas = new HashSet<Entrevista>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Reclutador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrevista> Entrevistas { get; set; }
    }
}
