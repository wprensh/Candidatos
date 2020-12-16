using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLibrary.Vo
{
    public partial class TipoTecnologia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public TipoTecnologia tipoTecnologia { get; set; }
    }
}
