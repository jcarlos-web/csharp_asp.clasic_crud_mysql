using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * @Autor <jCarlos:Mendoza/>
 * 
 * Proyecto: WebApplicactionASPClasic
 * Código:   UsuarioModel.cs
 * Fecha:    21/04/2017
 */

namespace WebApplicationASPClasic.models
{
    public class UsuarioModel
    {
        // Propiedades
        private int id_usuario;
        private string nombre;
        private string ap_pat;
        private string ap_mat;
        private string email;
        private string phone;
        private string usu;
        private string pw;
        private string activo;


        // Constructor vacio
        public UsuarioModel() { }

        // Constructor con parametros
        public UsuarioModel(int id_usuario, string nombre, string ap_pat, string ap_mat, string email, string phone, string usu, string pw, string activo)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.ap_pat = ap_pat;
            this.email = email;
            this.phone = phone;
            this.usu = usu;
            this.pw = pw;
            this.activo = activo;

        }

        // Métodos SET y GET
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Ap_pat
        {
            get { return ap_pat; }
            set { ap_pat = value; }
        }
        public string Ap_mat
        {
            get { return ap_mat; }
            set { ap_mat = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Usu
        {
            get { return usu; }
            set { usu = value; }
        }

        public string Pw
        {
            get { return pw; }
            set { pw = value; }
        }

        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }



    }
}