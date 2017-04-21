using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Importaciones
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using WebApplicationASPClasic.models;
/*
 * @Autor <jCarlos:Mendoza/>
 * 
 * Proyecto: WebApplicactionASPClasic
 * Código:   UsuarioController.cs
 * Fecha:    21/04/2017
 */

namespace WebApplicationASPClasic.controllers
{
    public class UsuarioController : System.Web.UI.Page
    {
        // Instancias
        private Conexion         conexion    = new Conexion();
        private Alert            alert       = new Alert();

        private MySqlConnection  connection;
        private MySqlCommand     command;
        private MySqlDataAdapter adapter;
        private DataSet          dataset;
        private String           sql;
        private int              result;


        // Método Read
        public DataSet readUsuario(string search)
        {
            sql = String.Format("SELECT * FROM usuario WHERE nombre LIKE '%{0}%'  ORDER BY id_usuario DESC", search);
            dataset = new DataSet("usuario");

            try
            {
                connection  = new MySqlConnection(conexion.getConnection());
                connection.Open();
                adapter     = new MySqlDataAdapter(sql, connection);
                adapter.Fill(dataset);
                connection.Close();
            }
            catch(Exception ex)
            {
                Response.Write(alert.alertMessage("Read: Ha surgido un error; "+ex.ToString(),"danger"));
                dataset = null;
            }

            // Eviar enlaces
            return dataset;
        }

        // Método getElementById
        public DataSet getUsuarioById(int id)
        {
            sql = String.Format("SELECT * FROM usuario WHERE id_usuario= '{0}' ", id);
            dataset = new DataSet("usuario");

            try
            {
                connection = new MySqlConnection(conexion.getConnection());
                connection.Open();
                adapter    = new MySqlDataAdapter(sql, connection);
                adapter.Fill(dataset);
                connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write(alert.alertMessage("getUsuarioById: Ha surgido un error; " + ex.ToString(), "danger"));
                dataset = null;
            }

            // Eviar enlaces
            return dataset;
        }

        // Método create
        public bool createUsuario(UsuarioModel model)
        {
            sql = String.Format("INSERT INTO usuario(nombre, ap_pat, ap_mat, email, phone, usu, pw, activo)"
                               + "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                               model.Nombre,
                               model.Ap_pat,
                               model.Ap_mat,
                               model.Email,
                               model.Phone,
                               model.Usu,
                               model.Pw,
                               model.Activo);

            try
            {
                connection = new MySqlConnection(conexion.getConnection());
                connection.Open();
                command    = new MySqlCommand(sql, connection);
                result     = command.ExecuteNonQuery();
                connection.Close();
                if (result != 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                Response.Write(alert.alertMessage("CreateUsuario: Ha surgido un error; " + ex.ToString(), "danger"));
                return false;
            }

        }

        // Método update
        public bool updateUsuario(UsuarioModel model)
        {
            sql = String.Format("UPDATE usuario SET nombre='{0}', ap_pat='{1}', ap_mat='{2}', email='{3}', phone='{4}', usu='{5}', pw='{6}', activo='{7}' WHERE id_usuario='{8}')",
                               model.Nombre,
                               model.Ap_pat,
                               model.Ap_mat,
                               model.Email,
                               model.Phone,
                               model.Usu,
                               model.Pw,
                               model.Activo,
                               model.Id_usuario);

            try
            {
                connection = new MySqlConnection(conexion.getConnection());
                connection.Open();
                command    = new MySqlCommand(sql, connection);
                result     = command.ExecuteNonQuery();
                connection.Close();
                if (result != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Response.Write(alert.alertMessage("UpdateUsuario: Ha surgido un error; " + ex.ToString(), "danger"));
                return false;
            }

        }

        // Método delete
        public bool deleteUsuario(UsuarioModel model)
        {
            sql = String.Format("DELETE FROM usuario WHERE id_usuario='{0}')",
                               model.Id_usuario);

            try
            {
                connection = new MySqlConnection(conexion.getConnection());
                connection.Open();
                command    = new MySqlCommand(sql, connection);
                result     = command.ExecuteNonQuery();
                connection.Close();
                if (result != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Response.Write(alert.alertMessage("DeleteUsuario: Ha surgido un error; " + ex.ToString(), "danger"));
                return false;
            }

        }

    }

}