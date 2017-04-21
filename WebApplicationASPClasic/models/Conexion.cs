using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * @Autor <jCarlos:Mendoza/>
 * 
 * Proyecto: WebApplicactionASPClasic
 * Código:   Conexion.cs
 * Fecha:    21/04/2017
 */

namespace WebApplicationASPClasic.models
{
    public class Conexion
    {
        // Propiedades
        private string host = "localhost";
        private string dbname = "db_proyecto";
        private string user = "root";
        private string pw = "";
        private string conexion;

        // Método getConnection
        public string getConnection()
        {
            try
            {
                conexion = "Server="+host+"; Database="+dbname+"; User id="+user+"; Pwd="+pw+" ";

            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha surgido un error y no se puede conectar a base de datos. Detalles: "+ex.ToString());
                conexion = null;
            }

            return conexion;
        }
    }
}