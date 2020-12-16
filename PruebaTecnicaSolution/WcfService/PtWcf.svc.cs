using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PruebaTecnicaLibrary.PruebaTecnicaService;
using PruebaTecnicaLibrary.Vo;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PtWcf" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PtWcf.svc or PtWcf.svc.cs at the Solution Explorer and start debugging.
    public class PtWcf : IPtWcf
    {
        PruebaTecnicaDb context = new PruebaTecnicaDb();

        public bool EditarEntrevista(Entrevista entrevista)
        {
            var entrevista_update = context.Entrevistas.Find(entrevista.Id);
            entrevista_update.Reclutador = entrevista.Reclutador;
            entrevista_update.Candidato = entrevista.Candidato;
            entrevista_update.Tipo_Entervista = entrevista.Tipo_Entervista;
            entrevista_update.Tipo_Tecnologia = entrevista.Tipo_Tecnologia;
            entrevista_update.Fecha_Entrevista = entrevista.Fecha_Entrevista;
            entrevista_update.Hora_Entrevista = entrevista.Hora_Entrevista;
            return (context.SaveChanges() == 1 ? true : false);
        }

        public bool NuevaEntrevista(Entrevista entrevista)
        {
            context.Entrevistas.Add(entrevista);
            return (context.SaveChanges() == 1?true:false);
        }

        public List<MyJsonData> ObtenerCandidatos()
        {
            return new Json_Service().GetReleases("http://jsonplaceholder.typicode.com");
        }

        public List<Entrevista> ObtenerEntrevistas()
        {
            List<Entrevista> entrevistas = new List<Entrevista>();
            List<MyJsonData> myJsonDatas = ObtenerCandidatos();
            foreach (var item in context.Entrevistas)
            {
                entrevistas.Add(new Entrevista()
                {
                    Id = item.Id,
                    Reclutador = item.Reclutador,
                    Reclutadore = item.Reclutadore,
                    Candidato = myJsonDatas.Where(x => x.id == item.Candidato).Select(y => y.id).FirstOrDefault(),
                    candicatoname = myJsonDatas.Where(x => x.id == item.Candidato).FirstOrDefault(),
                    Fecha_Entrevista = item.Fecha_Entrevista,
                    Hora_Entrevista = item.Hora_Entrevista,
                    Tipo_Entervista = item.Tipo_Entervista,
                    Tipo_Tecnologia = item.Tipo_Tecnologia
                });
            }
            return entrevistas;
        }

        public List<Reclutadore> ObtenerReclutadores()
        {
            List<Reclutadore> list_Reclutadores = new List<Reclutadore>();
            foreach (var item in context.Reclutadores)
            {
                list_Reclutadores.Add(new Reclutadore() { Id = item.Id, Reclutador = item.Reclutador });
            }
            return list_Reclutadores;
        }

        public List<Tecnologia> ObtenerTecnologias()
        {
            List<Tecnologia> tecnologias = new List<Tecnologia>() {
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
                        new TipoTecnologia(){ Id = 1, Descripcion = "Java Server Pages"},
                        new TipoTecnologia(){ Id = 2, Descripcion = "Java Server Faces"},
                        new TipoTecnologia(){ Id = 3, Descripcion = "Enterprise Java Beans"},
                        new TipoTecnologia(){ Id = 4, Descripcion = "Java Persistence Api"},
                        new TipoTecnologia(){ Id = 5, Descripcion = "Java Messaging Services"}
                    },
                }
            };
            return tecnologias;
        }

        public List<TipoTecnologia> ObtenerTipoTecnologias()
        {
            List<TipoTecnologia> tipoTecnologias = new List<TipoTecnologia>() {
                new TipoTecnologia(){ Id = 1, Descripcion = "Asp.Net"},
                new TipoTecnologia(){ Id = 2, Descripcion = "MVVM"},
                new TipoTecnologia(){ Id = 3, Descripcion = "Ado.Net"},
                new TipoTecnologia(){ Id = 4, Descripcion = "Entity FrameWork"},
                new TipoTecnologia(){ Id = 5, Descripcion = "LinQ"},
                new TipoTecnologia(){ Id = 6, Descripcion = "Java Server Pages"},
                new TipoTecnologia(){ Id = 7, Descripcion = "Java Server Faces"},
                new TipoTecnologia(){ Id = 8, Descripcion = "Enterprise Java Beans"},
                new TipoTecnologia(){ Id = 9, Descripcion = "Java Persistence Api"},
                new TipoTecnologia(){ Id = 10, Descripcion = "Java Messaging Services"}
            };
            return tipoTecnologias;
        }
    }
}
