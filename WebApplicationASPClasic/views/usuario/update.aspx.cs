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
 * Código:   update.aspx.cs
 * Fecha:    21/04/2017
 */

namespace WebApplicationASPClasic.views.usuario
{
    public partial class update : System.Web.UI.Page
    {
        // Propiedades
        private UsuarioModel model = new UsuarioModel();
        private UsuarioController controller = new UsuarioController();
        private Alert alert = new Alert();
        private DataSet dataset = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["query"] != null)
            {
                if(IsPostBack)
                {
                    int id = int.Parse(Request.QueryString["query"]);
                    dataset = controller.getUsuarioById(id);
                    cargarEnlace();
                }
            }
        }


        // procedimiento cargar Enlace
        public void cargarEnlace()
        {
            id_usuario.Value = dataset.Tables[0].Rows[0]["id_usuario"].ToString();
            nombre.Text = dataset.Tables[0].Rows[0]["nombre"].ToString();
            ap_pat.Text = dataset.Tables[0].Rows[0]["ap_pat"].ToString();
            ap_mat.Text = dataset.Tables[0].Rows[0]["ap_mat"].ToString();
            email.Text = dataset.Tables[0].Rows[0]["email"].ToString();
            phone.Text = dataset.Tables[0].Rows[0]["phone"].ToString();
            usu.Text = dataset.Tables[0].Rows[0]["usu"].ToString();
            pw.Text = dataset.Tables[0].Rows[0]["pw"].ToString();
            chk_activo.Checked = Convert.ToBoolean(Convert.ToInt32(dataset.Tables[0].Rows[0]["activo"].ToString()));


        }



        // Procedimiento UpdateUsuario
        public void updateUsuario()
        {
            model.Id_usuario = Convert.ToInt32(id_usuario.Value);
            model.Nombre = nombre.Text;
            model.Ap_pat = ap_pat.Text;
            model.Ap_mat = ap_mat.Text;
            model.Email = email.Text;
            model.Phone = phone.Text;
            model.Usu = usu.Text;
            model.Pw = pw.Text;

            // Pruba de errores
            try
            {
                if (controller.updateUsuario(model))
                    Response.Write(alert.alertMessage("Usuario editado correctamente.", "success"));
                else
                    Response.Write(alert.alertMessage("Usuario no fue editado.", "success"));
            }
            catch (Exception ex)
            {
                Response.Write(alert.alertMessage("Crear: Ha surgido un error; " + ex.ToString(), "danger"));
            }
        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            // Guardar los cambios
            updateUsuario();
            //Redirecionar
            Response.Write("<script> window.location='index.aspx' </script>");
        }




    }
}