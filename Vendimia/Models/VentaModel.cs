using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Vendimia.Models
{
    public class VentaModel
    {
        public int ClaveCiente { get; set; }
        public string Nombre { get; set; }
        public double Total { get; set; }
        public string Fecha { get; set; }
        public bool Estatus { get; set; }
        public string RFC { get; set; }

        public void Convertir(DataRow pRegistro)
        {
            this.Nombre = pRegistro["Nombre"] != DBNull.Value ? pRegistro["Nombre"].ToString().Trim() : "";
            this.RFC = pRegistro["RFC"] != DBNull.Value ? pRegistro["RFC"].ToString().Trim() : "";
            //this.Total = Double.Parse(pRegistro["Total"] != DBNull.Value ? pRegistro["Total"].ToString().Trim() : ""); 
            //this.Fecha = pRegistro["Fecha"] != DBNull.Value ? pRegistro["Fecha"].ToString().Trim() : "";
            //this.Estatus = Boolean.Parse(pRegistro["Estatus"] != DBNull.Value ? pRegistro["Estatus"].ToString().Trim() : "");
        }
    }
}