using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class DUsuario
    {
        // Funcion de login
        public string Login(string Email, string Password)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "usuario_login"
                SqlCommand Comando = new SqlCommand("usuario_login", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                Comando.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;

                //consulta para ejecutar el procedimiento almacenado
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                //especificando el tipo de variable que va retornar
                ParExiste.SqlDbType = SqlDbType.Int;

                //retornando el valor de respuesta de la query
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);

                //se abre la conexion con BD
                SqlCon.Open();

                //ejecutando query que no devuelve ningun valor
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                //si se genera conexion con exito, luego de tener los datos se cierra
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        // Funcion de verificar existencia de usuario
        public string Existe(string Email)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "usuario_existe"
                SqlCommand Comando = new SqlCommand("usuario_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;

                //consulta para ejecutar el procedimiento almacenado
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                //especificando el tipo de variable que va retornar
                ParExiste.SqlDbType = SqlDbType.Int;

                //retornando el valor de respuesta de la query
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);

                //se abre la conexion con BD
                SqlCon.Open();

                //ejecutando query que no devuelve ningun valor
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                //si se genera conexion con exito, luego de tener los datos se cierra
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        //Funcion de listar usuarios (maestros)
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //para obtener la conexion con la BD, se llaman las funciones en la clase Conexion
                SqlCon = Conexion.getInstancia().CrearConexion();

                //para tener los datos se necesita llama un procedimiento almacenado "usuario_listar" dentro de SQL Server
                SqlCommand Comando = new SqlCommand("usuario_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //se abre la conexion con BD
                SqlCon.Open();

                //ejecutando el procedimiento almacenado
                Resultado = Comando.ExecuteReader();

                //llenando la tabla con la informacion de la ejecucion del comando
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //si se genera conexion con exito, luego de tener los datos se cierra
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        //Funcion de obtener rol de usario
        public string Get_Rol(string Email)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "usuario_rol"
                SqlCommand Comando = new SqlCommand("usuario_rol", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;

                //consulta para ejecutar el procedimiento almacenado
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                //especificando el tipo de variable que va retornar
                ParExiste.SqlDbType = SqlDbType.Int;

                //retornando el valor de respuesta de la query
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);

                //se abre la conexion con BD
                SqlCon.Open();

                //ejecutando query que no devuelve ningun valor
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                //si se genera conexion con exito, luego de tener los datos se cierra
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

    }
}
