using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Vendimia.Models;

namespace Vendimia.Auxiliares
{
    public class DBCatalogos : DBConexion
    {
        private static string SP_VEN_OBTENER_CLIENTE = "VEN_OBTENER_CLIENTE";
        private static string SP_VEN_OBTENER_ARTICULO = "VEN_OBTENER_ARTICULO";

        //public static List<VentaModel> obtenerClientes(VentaModel form)
        //{
        //    List<VentaModel> lista = null;
        //    try
        //    {
        //        DataTable dt = EjecutarSPConResultados(SP_VEN_OBTENER_CLIENTE, null);
        //        if (dt != null && dt.Rows.Count > 0)
        //        {
        //            lista = new List<VentaModel>();
        //            foreach (DataRow dr in dt.Rows)
        //            {
        //                VentaModel elemento = new VentaModel();
        //                elemento.Convertir(dr);
        //                lista.Add(elemento);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    return lista;
        //}

        public static List<VentaModel> obtenerClientes(VentaModel form)
        {
            List<VentaModel> data = new List<VentaModel>();
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@nombrecompleto", form.Nombre));
               DataTable dt = EjecutarSPConResultados(SP_VEN_OBTENER_CLIENTE, parametros.ToArray());

                if (dt != null && dt.Rows.Count > 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        VentaModel elemento = new VentaModel();
                        elemento.Convertir(dr);
                        data.Add(elemento);
                    }
                }
            }
            catch (Exception ex)
            {

            }

           return data;
        }
    }
}