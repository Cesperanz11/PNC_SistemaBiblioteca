using System;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            //Asginando las variables para generar la conexion con la BD
            this.Base = "proyectofinal_biblioteca";
            this.Servidor = "DESKTOP-BQRAI5N\\SQLEXPRESS"; //Cambiar por "192.168.134.1" y Seguridad = false
            this.Usuario = "sa";
            this.Clave = "uca";
            this.Seguridad = true; //Seguridad de Windows (false debido a que se esta utilizando una maquina virtual para el servidor)
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                //Se llena la cadena de conexion con los datos ingresados anteriormente, dependiendo del tipo de seguridad que se desea.
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad) //Seguridad de Windows
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else //Seguridad de SQL Server
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave + ";";
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            //En primer lugar se valida que la Conexion exista, de no ser asi, se crea una nueva conexion con la BD
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
