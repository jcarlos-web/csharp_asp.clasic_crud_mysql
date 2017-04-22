using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//importar
using WebApplicationASPClasic.models;
using WebApplicationASPClasic.controllers;
using System.Data;

namespace WebApplicationASPClasic.views.usuario
{
    public partial class editar : System.Web.UI.Page
    {
        // instancias y propiedades
        private DataSet dataset;
        private UsuarioModel model = new UsuarioModel();
        private UsuarioController controller = new UsuarioController();
        private Alert alert = new Alert();

        protected void Page_Load(object sender, EventArgs e)
        {

            if(Request.QueryString["_query"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["_query"]);


                if (!Page.IsPostBack)
                {
                    dataset = controller.getUsuarioById(id);
                    txtNombre.Text = dataset.Tables[0].Rows[0]["nombre"].ToString();
                    txtAp_pat.Text = dataset.Tables[0].Rows[0]["ap_pat"].ToString();
                    txtAp_mat.Text = dataset.Tables[0].Rows[0]["ap_mat"].ToString();
                    txtEmail.Text = dataset.Tables[0].Rows[0]["email"].ToString();
                    txtPhone.Text = dataset.Tables[0].Rows[0]["phone"].ToString();
                    txtUsu.Text = dataset.Tables[0].Rows[0]["usu"].ToString();
                    txtPw.Text = dataset.Tables[0].Rows[0]["pw"].ToString();
                    chk_estado.Checked = Convert.ToBoolean(Convert.ToInt32(dataset.Tables[0].Rows[0]["activo"].ToString()));
                }

            }
        }
        

            // Procedimiento UpdateUsuario
            public void updateUsuario()
            {
                int estado = 0;
                model.Id_usuario = Convert.ToInt32(Request.QueryString["_query"]);
                model.Nombre = txtNombre.Text;
                model.Ap_pat = txtAp_pat.Text;
                model.Ap_mat = txtAp_mat.Text;
                model.Email = txtEmail.Text;
                model.Phone = txtPhone.Text;
                model.Usu = txtUsu.Text;
                model.Pw = txtPw.Text;
                if(chk_estado.Checked)
                {
                    estado = 1;
                }
                model.Activo = estado;

                if (controller.updateUsuario(model))
                    Response.Write(alert.alertMessage("Usuario editado correctamente.","info"));
                else
                    Response.Write(alert.alertMessage("Usuario no editado.", "info"));

            }
        
        protected void btn_update_Click(object sender, EventArgs e)
            {
                updateUsuario();
                Response.Redirect("index.aspx");
            }


        }



    }
