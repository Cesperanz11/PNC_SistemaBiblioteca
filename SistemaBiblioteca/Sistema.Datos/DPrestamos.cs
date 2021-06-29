using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DPrestamos
    {
        //Funcion para listar los prestamos de libros de un maestro
        public DataTable Listar_Libros( int id_usuario)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //para obtener la conexion con la BD, se llaman las funciones en la clase Conexion
                SqlCon = Conexion.getInstancia().CrearConexion();

                //para tener los datos se necesita llama un procedimiento almacenado "prestamoslibros_listar" dentro de SQL Server
                SqlCommand Comando = new SqlCommand("prestamoslibros_listar", SqlCon);
                Comando.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;
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

        //Funcion para insertar un prestamo de libros
        public string Insertar_Libros(PrestamoLibros Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "prestamoslibros_insertar"
                SqlCommand Comando = new SqlCommand("prestamoslibros_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@id_libro", SqlDbType.Int).Value = Obj.id_libro;
                Comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Obj.id_usuario;
                Comando.Parameters.Add("@fecha_inicial", SqlDbType.Date).Value = Obj.fecha_inicial;
                Comando.Parameters.Add("@fecha_final", SqlDbType.Date).Value = Obj.fecha_final;

                //se abre la conexion
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el prestamo del libro";
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


        //Funcion para eliminar prestamo de libros
        public string Eliminar_Libros(int id_prestamo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("prestamoslibros_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_prestamo", SqlDbType.Int).Value = id_prestamo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el prestamo del libro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;
        }








        //Funcion para listar los prestamos de videos de un maestro
        public DataTable Listar_Videos(int id_usuario)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //para obtener la conexion con la BD, se llaman las funciones en la clase Conexion
                SqlCon = Conexion.getInstancia().CrearConexion();

                //para tener los datos se necesita llama un procedimiento almacenado "prestamosvideos_listar" dentro de SQL Server
                SqlCommand Comando = new SqlCommand("prestamosvideos_listar", SqlCon);
                Comando.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;
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

        //Funcion para insertar un prestamo de libros
        public string Insertar_Videos(PrestamoVideos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "prestamosvideos_insertar"
                SqlCommand Comando = new SqlCommand("prestamosvideos_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@id_video", SqlDbType.Int).Value = Obj.id_video;
                Comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Obj.id_usuario;
                Comando.Parameters.Add("@fecha_inicial", SqlDbType.Date).Value = Obj.fecha_inicial;
                Comando.Parameters.Add("@fecha_final", SqlDbType.Date).Value = Obj.fecha_final;

                //se abre la conexion
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el prestamo del libro";
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


        //Funcion para eliminar prestamo de videos
        public string Eliminar_Videos(int id_prestamo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("prestamosvideos_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_prestamo", SqlDbType.Int).Value = id_prestamo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el prestamo del video";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;
        }

    }
}
