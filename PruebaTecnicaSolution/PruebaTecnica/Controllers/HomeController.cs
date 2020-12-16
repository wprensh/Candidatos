using PruebaTecnica.ServiceReference;
using PruebaTecnicaLibrary.PruebaTecnicaService;
using PruebaTecnicaLibrary.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTecnica.Controllers
{
    public class HomeController : Controller
    {
        PruebaTecnicaDb context = new PruebaTecnicaDb();
        PtWcfClient ptWcfClient = new PtWcfClient();
        DatosAuxiliares datosAuxiliares = new DatosAuxiliares();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Pruebas()
        {
            List<Entrevista> entrevistas = new List<Entrevista>();

            Json_Service json_Service = new Json_Service();
            List<MyJsonData> myJsonDatas = json_Service.GetReleases("http://jsonplaceholder.typicode.com");
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

            //var result = from entreview in entrevistas join candidatos in myJsonDatas 
            //             on entreview.Candidato equals candidatos.id
            //             select new {
            //                 entreview.Id,
            //                 entreview.Candidato,
            //                 entreview.Reclutador,
            //                 entreview.Fecha_Entrevista,
            //                 entreview.Hora_Entrevista,
            //                 entreview.Tipo_Entervista,
            //                 entreview.Tipo_Tecnologia,
            //                 candidatos.name
            //             };

            return View(entrevistas);
        }



        /// <summary>  
        /// This method will return PartialView with Employee Model  
        /// </summary>  
        /// <param name="EmployeeId"></param>  
        /// <returns></returns>  
        public PartialViewResult getByIdTecnologia(int idTegnologia)
        {
            ViewBag.LstTipoTecnologia = datosAuxiliares.tecnologias.Where(s => s.Id == idTegnologia).Select(m => m.tipoTecnologias).ToList();

            return PartialView("_getByIdTecnologia");
        }



        public ActionResult AddPruebas()
        {
            ViewBag.Accounts = datosAuxiliares.tecnologias;
            Entrevista entrevista_obj = new Entrevista()
            {
                reclutadores = datosAuxiliares.GetReclutadores()
            };

            return View(entrevista_obj);
        }

        [HttpPost]
        public ActionResult AddPruebas(Entrevista entrevista)
        {            
            if (ptWcfClient.NuevaEntrevista(entrevista) == true)
            {
                return Redirect("Pruebas");
            }
            return View(entrevista);
            
        }

        public ActionResult ModifyPruebas(int id) {
            Entrevista entrevista = context.Entrevistas.Where(e => e.Id == id).FirstOrDefault();
            entrevista.reclutadores = datosAuxiliares.GetReclutadores();
            return View(entrevista);
        }

        [HttpPost]
        public ActionResult ModifyPruebas(Entrevista entrevista) {
            if (ptWcfClient.EditarEntrevista(entrevista) == true)
            {
                return Redirect("Pruebas");
            }
            return View(entrevista);
        }
    }
}