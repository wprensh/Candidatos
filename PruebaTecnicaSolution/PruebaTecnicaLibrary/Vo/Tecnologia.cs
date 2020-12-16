using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLibrary.Vo
{
    public partial class Tecnologia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int TipoTecnologia { get; set; }
        public ICollection<TipoTecnologia> tipoTecnologias { get; set; }
    }
}
