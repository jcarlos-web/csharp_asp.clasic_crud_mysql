using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Importar
using WebApplicationASPClasic.controllers;
using WebApplicationASPClasic.models;
using System.Data;
using WebApplicationASPClasic.views.usuario;
/*
 * @Autor <jCarlos:Mendoza/>
 * 
 * Proyecto: WebApplicactionASPClasic
 * Código:   index.cs
 * Fecha:    21/04/2017
 */
namespace WebApplicationASPClasic.views.usuario
{
    public partial class index : System.Web.UI.Page
    {
        // Propiedades
        private UsuarioModel      model      = new UsuarioModel();
        private UsuarioController controller = new UsuarioController();
        private Alert             alert      = new Alert();
        private DataSet           dataset    = new DataSet();



        protected void Page_Load(object sender, EventArgs e)
        {
            // Cargamos los enlaces
            readUsuario();

            // Obtener parametros para nuevo usuario

        }


        // Procedimiento ReadUsuario
        public void readUsuario()
        {
            
            try
            {
                this.list_usuario.DataSource = controller.readUsuario("");
                this.list_usuario.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(alert.alertMessage("Index: ha surgido un error: "+ex.ToString(),"danger"));
            }
        }

        // Procedimiento CreateUsuario



    }
}