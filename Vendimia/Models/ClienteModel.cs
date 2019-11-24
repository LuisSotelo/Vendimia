using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Vendimia.Models
{
    public class ClienteModel
    {
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string RFC { get; set; }

        public void Convertir(DataRow pRegistro)
        {
            this.Nombre = pRegistro["Nombre"] != DBNull.Value ? pRegistro["Nombre"].ToString().Trim() : "";
            this.ApPaterno = pRegistro["ApPaterno"] != DBNull.Value ? pRegistro["ApPaterno"].ToString().Trim() : "";
            this.ApMaterno = pRegistro["ApMaterno"] != DBNull.Value ? pRegistro["ApMaterno"].ToString().Trim() : "";
            this.RFC = pRegistro["RFC"] != DBNull.Value ? pRegistro["RFC"].ToString().Trim() : "";
        }
    }
}