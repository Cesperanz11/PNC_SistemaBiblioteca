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
        public DataTable Listar_Libros(int id_libro, int id_usuario)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //para obtener la conexion con la BD, se llaman las funciones en la clase Conexion
                SqlCon = Conexion.getInstancia().CrearConexion();

                //para tener los datos se necesita llama un procedimiento almacenado "usuario_listar" dentro de SQL Server
                SqlCommand Comando = new SqlCommand("prestamoslibros_listar", SqlCon);
                Comando.Parameters.Add("id_libro", SqlDbType.Int).Value = id_libro;
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

    }
}
