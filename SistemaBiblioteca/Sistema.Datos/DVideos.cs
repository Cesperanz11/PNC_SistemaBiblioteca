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
    public class DVideos
    {
        //Funcion de listar videos
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //para obtener la conexion con la BD, se llaman las funciones en la clase Conexion
                SqlCon = Conexion.getInstancia().CrearConexion();

                //para tener los datos se necesita llama un procedimiento almacenado "videos_listar" dentro de SQL Server
                SqlCommand Comando = new SqlCommand("videos_listar", SqlCon);
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

        //Funcion de insertar videos
        public string Insertar(Videos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "videos_insertar"
                SqlCommand Comando = new SqlCommand("videos_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@director", SqlDbType.VarChar).Value = Obj.director;
                Comando.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.productora;
                Comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Obj.tipo;
                Comando.Parameters.Add("@anio", SqlDbType.Int).Value = Obj.anio;
                Comando.Parameters.Add("@duracion", SqlDbType.Int).Value = Obj.duracion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@subtitulos", SqlDbType.VarChar).Value = Obj.subtitulos;
                Comando.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.clasificacion;
                Comando.Parameters.Add("@genero", SqlDbType.VarChar).Value = Obj.genero;
                Comando.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.sinopsis;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;

                //se abre la conexion
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro de video";
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

        //Funcion para validar existencia del video
        public string Existe(string titulo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "videos_insertar"
                SqlCommand Comando = new SqlCommand("videos_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;

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

        //Funcion de buscar videos
        public DataTable Buscar(string Valor, int criterio)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("videos_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                Comando.Parameters.Add("@type", SqlDbType.Int).Value = criterio;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


        }

        //Funcion para obtener video al actualizar
        public DataTable Obtener(int id_video)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("videos_obtener", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_video", SqlDbType.Int).Value = id_video;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


        }

        //Funcion de actualizar videos
        public string Actualizar(Videos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("videos_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@id_video", SqlDbType.Int).Value = Obj.id_video;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@director", SqlDbType.VarChar).Value = Obj.director;
                Comando.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.productora;
                Comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Obj.tipo;
                Comando.Parameters.Add("@anio", SqlDbType.Int).Value = Obj.anio;
                Comando.Parameters.Add("@duracion", SqlDbType.Int).Value = Obj.duracion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@subtitulos", SqlDbType.VarChar).Value = Obj.subtitulos;
                Comando.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.clasificacion;
                Comando.Parameters.Add("@genero", SqlDbType.VarChar).Value = Obj.genero;
                Comando.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.sinopsis;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro del video";
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

        //Funcion de validar existencia del video al Actualizar
        public string BuscarID(int id_video)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "videos_buscarId"
                SqlCommand Comando = new SqlCommand("videos_buscarId", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@id_video", SqlDbType.Int).Value = id_video;

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

        //Funcion de eliminar videos
        public string Eliminar(int id_video)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("videos_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_video", SqlDbType.Int).Value = id_video;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el video";
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
