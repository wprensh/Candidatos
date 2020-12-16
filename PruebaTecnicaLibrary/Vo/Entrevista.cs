namespace PruebaTecnicaLibrary.Vo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tecnologia_Tbl.Entrevistas")]
    public partial class Entrevista
    {
        public int Id { get; set; }

        public int Reclutador { get; set; }

        public int Candidato { get; set; }

        [NotMapped]
        public MyJsonData candicatoname { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Entrevista { get; set; }

        public TimeSpan Hora_Entrevista { get; set; }

        public int Tipo_Entervista { get; set; }

        public int Tipo_Tecnologia { get; set; }

        public virtual Reclutadore Reclutadore { get; set; }

        [NotMapped]
        public List<Reclutadore> reclutadores { get; set; }


    }
}
