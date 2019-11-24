using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendimia.Models;

namespace Vendimia.Auxiliares
{
    public class LogicaDatos
    {
        public static List<VentaModel> obtenerDatosNomina(VentaModel form)
        {
            return DBCatalogos.obtenerClientes(form);
        }
    }
}