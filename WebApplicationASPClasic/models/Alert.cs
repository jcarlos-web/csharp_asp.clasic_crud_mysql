using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * @Autor <jCarlos:Mendoza/>
 * 
 * Proyecto: WebApplicactionASPClasic
 * Código:   Alert.cs
 * Fecha:    21/04/2017
 */

namespace WebApplicationASPClasic.models
{
    public class Alert
    {
        // Propiedades
        private string mensaje;
        private string clase;
        private string forward;

        // Constructor sin parametros
        public Alert() { }

        // Constructor con parametros
        public Alert(string mensaje, string clase)
        {
            this.mensaje = mensaje;
            this.clase = clase;
        }

        // Métodos SET y GET
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public string Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        // Método Alert
        public string alertMessage(string mensaje, string clase)
        {
            switch(clase)
            {
                case "success":
                    clase = "alert alert-succes";
                    break;
                case "danger":
                    clase = "alert alert-danger";
                    break;
                case "info":
                    clase = "alert alert-info";
                    break;
                default:
                    clase = "alert alert-default";
                    break;
            }

            // Empaquetar mensaje
            forward = "<div class='"+clase+"' align='center' ><a href='#' type='button' class='close' data-dismiss='alert' aria-label='close' >&times</a><strong>"+mensaje+"</strong></div>";
            // Enviamos mensaje empaquetado
            return forward;
        }


    }
}