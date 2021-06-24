using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Datos
{
    public class DLibros
    {
        //Funcion de listar libros
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //para obtener la conexion con la BD, se llaman las funciones en la clase Conexion
                SqlCon = Conexion.getInstancia().CrearConexion();

                //para tener los datos se necesita llama un procedimiento almacenado "libros_listar" dentro de SQL Server
                SqlCommand Comando = new SqlCommand("libros_listar", SqlCon);
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

        //Funcion de insertar libros

        //Funcion de actualizar libros

        //Funcion de eliminar libros
    }
}
