using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLibrary.Vo
{
    public partial class Geo
    {
        [Key]
        public int Id { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
