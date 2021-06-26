using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Sistema.Entidades;

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
        public string Insertar(Libros Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "libros_insertar"
                SqlCommand Comando = new SqlCommand("libros_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@numero_ejemplares", SqlDbType.Int).Value = Obj.numero_ejemplares;
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.isbn;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.editorial;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.Int).Value = Obj.anio_edicion;
                Comando.Parameters.Add("@numero_edicion", SqlDbType.VarChar).Value = Obj.numero_edicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.materia;
                Comando.Parameters.Add("@numero_pagina", SqlDbType.Int).Value = Obj.numero_pagina;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;


                //se abre la conexion
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro del libro";
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

        //Funcion para validar existencia del libro
        public string Existe(string isbn)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //creando conexion con la BD
                SqlCon = Conexion.getInstancia().CrearConexion();

                //generando nuevo comando para ejecutar en SQL Server el procedimiento almacenado "libros_existe"
                SqlCommand Comando = new SqlCommand("libros_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = isbn;

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

        //Funcion de buscar libros
        public DataTable Buscar(string Valor, int criterio)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_buscar", SqlCon);
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

        //Funcion de actualizar libros
        public string Actualizar(Libros Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Declarando value de los parametros dentro del procedimiento almacenado
                Comando.Parameters.Add("@numero_ejemplares", SqlDbType.Int).Value = Obj.numero_ejemplares;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.editorial;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.Int).Value = Obj.anio_edicion;
                Comando.Parameters.Add("@numero_edicion", SqlDbType.VarChar).Value = Obj.numero_edicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.materia;
                Comando.Parameters.Add("@numero_pagina", SqlDbType.Int).Value = Obj.numero_pagina;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro del libro";
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

        //Funcion de eliminar libros
    }
}
