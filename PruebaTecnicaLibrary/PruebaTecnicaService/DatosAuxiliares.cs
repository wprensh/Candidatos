using PruebaTecnicaLibrary.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLibrary.PruebaTecnicaService
{
    public class DatosAuxiliares
    {
        PruebaTecnicaDb context = new PruebaTecnicaDb();


       public List<Tecnologia> tecnologias = new List<Tecnologia>() {
                new Tecnologia { Id = 1, Descripcion = "Microsoft .Net",
                    tipoTecnologias = new List<TipoTecnologia>()
                    {
                        new TipoTecnologia(){ Id = 1, Descripcion = "Asp.Net"},
                        new TipoTecnologia(){ Id = 2, Descripcion = "MVVM"},
                        new TipoTecnologia(){ Id = 3, Descripcion = "Ado.Net"},
                        new TipoTecnologia(){ Id = 4, Descripcion = "Entity FrameWork"},
                        new TipoTecnologia(){ Id = 5, Descripcion = "LinQ"}
                    }
                },
                new Tecnologia { Id = 2, Descripcion = "Oracle Java",
                    tipoTecnologias = new List<TipoTecnologia>()
                    {
                        new TipoTecnologia(){ Id = 6, Descripcion = "Java Server Pages"},
                        new TipoTecnologia(){ Id = 7, Descripcion = "Java Server Faces"},
                        new TipoTecnologia(){ Id = 8, Descripcion = "Enterprise Java Beans"},
                        new TipoTecnologia(){ Id = 9, Descripcion = "Java Persistence Api"},
                        new TipoTecnologia(){ Id = 10, Descripcion = "Java Messaging Services"}
                    },
                }
                
                
                //new Tecnologia(){ Id = 2, Descripcion = "Oracle Java", tipoTecnologias = new List<TipoTecnologia>(GetOracleTipoTecnologias()) }

            };


        public List<TipoTecnologia> GetMicrosoftTipoTecnologias()
        {
            List<TipoTecnologia> tipoTecnologias = new List<TipoTecnologia>() {
                new TipoTecnologia(){ Id = 1, Descripcion = "Asp.Net"},
                new TipoTecnologia(){ Id = 2, Descripcion = "MVVM"},
                new TipoTecnologia(){ Id = 3, Descripcion = "Ado.Net"},
                new TipoTecnologia(){ Id = 4, Descripcion = "Entity FrameWork"},
                new TipoTecnologia(){ Id = 5, Descripcion = "LinQ"}
            };
            return tipoTecnologias;
        }

        public List<TipoTecnologia> GetOracleTipoTecnologias()
        {
            List<TipoTecnologia> tipoTecnologias = new List<TipoTecnologia>() {
                new TipoTecnologia(){ Id = 6, Descripcion = "Java Server Pages"},
                new TipoTecnologia(){ Id = 7, Descripcion = "Java Server Faces"},
                new TipoTecnologia(){ Id = 8, Descripcion = "Enterprise Java Beans"},
                new TipoTecnologia(){ Id = 9, Descripcion = "Java Persistence Api"},
                new TipoTecnologia(){ Id = 10, Descripcion = "Java Messaging Services"}
            };
            return tipoTecnologias;
        }

        public List<Reclutadore> GetReclutadores()
        {
            List<Reclutadore> list_Reclutadores = new List<Reclutadore>();
            foreach (var item in context.Reclutadores)
            {
                list_Reclutadores.Add(new Reclutadore() { Id = item.Id, Reclutador = item.Reclutador });
            }
            return list_Reclutadores;
        }
    }
}
