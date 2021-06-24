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
    }
}
