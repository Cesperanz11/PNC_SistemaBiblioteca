using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NVideos
    {
        // Funcion de listar videos
        public static DataTable Listar()
        {
            //Se utiliza la funcion de la clase Datos para obtener la informacion
            DVideos Datos = new DVideos();
            return Datos.Listar();
        }

        // Funcion de insertar video
        public static string Insertar(string titulo, string director, string productora, string tipo, int anio,
            int duracion, string pais, string idioma, string subtitulos, string clasificacion, string genero,
            string sinopsis, string ubicacion)
        {
            //Utiizando funcion para verificar que no se haya ingesado anteriormente
            DVideos Datos = new DVideos();
            string Existe = Datos.Existe(titulo);

            //validando que el nuevo video ingresado no exista en la BD
            if (Existe.Equals("1"))
            {
                return "El video ya existe";
            }
            else
            {
                //si no existe se asigna los valores al objeto para posteriormente ejecutarlo
                Videos Obj = new Videos();
                Obj.titulo = titulo;
                Obj.director = director;
                Obj.productora = productora;
                Obj.tipo = tipo;
                Obj.anio = anio;
                Obj.duracion = duracion;
                Obj.pais = pais;
                Obj.idioma = idioma;
                Obj.subtitulos = subtitulos;
                Obj.clasificacion = clasificacion;
                Obj.genero = genero;
                Obj.sinopsis = sinopsis;
                Obj.ubicacion = ubicacion;

                return Datos.Insertar(Obj);
            }
        }

        // Funcion de buscar videos
        public static DataTable Buscar(string Valor, int criterio)
        {
            DVideos Datos = new DVideos();

            return Datos.Buscar(Valor, criterio);
        }

        // Funcion de obtener videos al actualizar
        public static DataTable Obtener(int id_video)
        {
            DVideos Datos = new DVideos();

            return Datos.Obtener(id_video);
        }

        // Funcion para actualizar libros
        public static string Actualizar(int id_video, string titulo, string director, string productora, string tipo, int anio,
            int duracion, string pais, string idioma, string subtitulos, string clasificacion, string genero,
            string sinopsis, string ubicacion)
        {
            DVideos Datos = new DVideos();
            Videos Obj = new Videos();

            //Como ponemos a disposicion del admin todos los campos y sus valores, el es responsable de mandar la info de manera
            //correcta y ya editada
            //Mandamos en un objetvo Libros todos los parametros.
            Obj.id_video = id_video;
            Obj.titulo = titulo;
            Obj.director = director;
            Obj.productora = productora;
            Obj.tipo = tipo;
            Obj.anio = anio;
            Obj.duracion = duracion;
            Obj.pais = pais;
            Obj.idioma = idioma;
            Obj.subtitulos = subtitulos;
            Obj.clasificacion = clasificacion;
            Obj.genero = genero;
            Obj.sinopsis = sinopsis;
            Obj.ubicacion = ubicacion;

            return Datos.Actualizar(Obj);
        }

        // Funcion para buscar video por ID
        public static string BuscarID(int id_video)
        {
            DVideos Datos = new DVideos();
            string Rpta = "";

            Rpta = Datos.BuscarID(id_video);
            if (Rpta.Equals("0"))
            {
                return "El ID de video que se ha consultado no existe en la BD";
            }
            else
            {
                return "OK";
            }

        }
    }
}
