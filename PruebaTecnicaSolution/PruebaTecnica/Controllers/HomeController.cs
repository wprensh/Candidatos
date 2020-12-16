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
            
            return View(ptWcfClient.ObtenerEntrevistas());
        }



        /// <summary>  
        /// This method will return PartialView with Employee Model  
        /// </summary>  
        /// <param name="EmployeeId"></param>  
        /// <returns></returns>  
        public PartialViewResult getByIdTecnologia(int idTegnologia)
        {
            ViewBag.LstTipoTecnologia = ptWcfClient.ObtenerTecnologias().Where(s => s.Id == idTegnologia).Select(m => m.tipoTecnologias).ToList();

            return PartialView("_getByIdTecnologia");
        }



        public ActionResult AddPruebas()
        {
            ViewBag.Accounts = datosAuxiliares.tecnologias;
            Entrevista entrevista_obj = new Entrevista()
            {
                reclutadores = ptWcfClient.ObtenerReclutadores().ToList()
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