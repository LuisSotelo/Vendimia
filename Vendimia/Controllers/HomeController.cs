using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vendimia.Auxiliares;
using Vendimia.Models;

namespace Vendimia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ventas()
        {
            return View("Ventas");
        }

       public ActionResult NuevaVenta()
        {
            return View("RegistroVenta");
        }

        [HttpPost]
        public JsonResult buscaNombre(string Prefix)
        {
            //Note : you can bind same list from database  
            List<VentaModel> ObjList = new List<VentaModel>();
            VentaModel modelo = new VentaModel();
            modelo.Nombre = Prefix;
            var Nombre  = LogicaDatos.obtenerDatosNomina(modelo);

            //Searching records from list using LINQ query  
            var CityList = (from N in ObjList
                            where N.Nombre.StartsWith(Prefix)
                            select new { N.Nombre });
            return Json(Nombre, JsonRequestBehavior.AllowGet);
        }
    }
}