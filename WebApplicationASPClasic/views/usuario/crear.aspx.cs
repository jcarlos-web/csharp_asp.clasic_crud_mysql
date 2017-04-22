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
 * Código:   crear.cs
 * Fecha:    21/04/2017
 */

namespace WebApplicationASPClasic.views.usuario
{
    public partial class crear : System.Web.UI.Page
    {
        // Propiedades
        private UsuarioModel model = new UsuarioModel();
        private UsuarioController controller = new UsuarioController();
        private Alert alert = new Alert();
        private DataSet dataset = new DataSet();
        private index view = new index();

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        // Procedimiento CreateUsuario
        public void createUsuario()
        {
            int estado = 0;
            model.Nombre = nombre.Text;
            model.Ap_pat = ap_pat.Text;
            model.Ap_mat = ap_mat.Text;
            model.Email  = email.Text;
            model.Phone  = phone.Text;
            model.Usu    = usu.Text;
            model.Pw     = pw.Text;

            // valor para estado del usuario
            if(chk_activo.Checked)
            {
                estado = 1;
            }

            // Pruba de errores
            try
            {
                if (controller.createUsuario(model))
                    Response.Write(alert.alertMessage("Usuario creado correctamente.","success"));
                else
                    Response.Write(alert.alertMessage("Usuario no fue creado.", "success"));
            }
            catch(Exception ex)
            {
                Response.Write(alert.alertMessage("Crear: Ha surgido un error; "+ex.ToString(),"danger"));
            }
        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            // Crear el usuario
            createUsuario();
            // rediccionarar 
            Response.Redirect("index.aspx");

        }


    }
}