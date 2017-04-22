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
 * Código:   delete.aspx.cs
 * Fecha:    21/04/2017
 */

namespace WebApplicationASPClasic.views.usuario
{
    public partial class delete : System.Web.UI.Page
    {
        // Propiedades
        private UsuarioModel model = new UsuarioModel();
        private UsuarioController controller = new UsuarioController();
        private Alert alert = new Alert();
        private DataSet dataset = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["query"] != null)
            {
                int id = int.Parse(Request.QueryString["query"]);
                    dataset = controller.getUsuarioById(id);
                    cargarEnlace();
            }
        }

        // procedimiento cargar Enlace
        public void cargarEnlace()
        {
            id_usuario.Value = dataset.Tables[0].Rows[0]["id_usuario"].ToString();
            nombre.Text = dataset.Tables[0].Rows[0]["nombre"].ToString();
            ap_pat.Text = dataset.Tables[0].Rows[0]["ap_pat"].ToString();
            ap_mat.Text = dataset.Tables[0].Rows[0]["ap_mat"].ToString();
        }

        // procedimiento DeleteUsuario
        public void deleteUsuario()
        {
            model.Id_usuario = Convert.ToInt32(Request.QueryString["query"]);

            if (controller.deleteUsuario(model))
                Response.Write(alert.alertMessage("Usuario eliminado correctamente.","info"));
            else
                Response.Write(alert.alertMessage("Usuario no eliminado.", "danger"));
        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            // Eliminar usuario
            deleteUsuario();
            Response.Redirect("index.aspx");

        }




    }
}