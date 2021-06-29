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
    public class NPrestamos
    {

        // Funcion de listar prestamos de libros de un maestro
        public static DataTable Listar_Libros( int id_usuario)
        {
            //Se utiliza la funcion de la clase Datos para obtener la informacion
            DPrestamos Datos = new DPrestamos();
            return Datos.Listar_Libros(id_usuario);
        }


        // Funcion para insertar prestamos de libros
        public static string Insertar_Libros(int id_libro, int id_usuario, DateTime fecha_inicial, DateTime fecha_final )
        {
            //Utiizando funcion para verificar que no se haya ingesado anteriormente
            DPrestamos Datos = new DPrestamos();

            //Se asignan los valores al objeto para posteriormente ejecutarlo
            PrestamoLibros Obj = new PrestamoLibros();
            Obj.id_libro = id_libro;
            Obj.id_usuario = id_usuario;
            Obj.fecha_inicial = fecha_inicial;
            Obj.fecha_final = fecha_final;

            return Datos.Insertar_Libros(Obj);
        }


        // Funcion para eliminar prestamos de libros
        public static string Eliminar_Libros(int id_prestamo)
        {
            DPrestamos Datos = new DPrestamos();

            return Datos.Eliminar_Libros(id_prestamo);
        }




        // Funcion de listar prestamos de videos de un maestro
        public static DataTable Listar_Videos(int id_usuario)
        {
            //Se utiliza la funcion de la clase Datos para obtener la informacion
            DPrestamos Datos = new DPrestamos();
            return Datos.Listar_Videos(id_usuario);
        }


        // Funcion para insertar prestamos de videos
        public static string Insertar_Videos(int id_video, int id_usuario, DateTime fecha_inicial, DateTime fecha_final)
        {
            //Utiizando funcion para verificar que no se haya ingesado anteriormente
            DPrestamos Datos = new DPrestamos();

            //Se asignan los valores al objeto para posteriormente ejecutarlo
            PrestamoVideos Obj = new PrestamoVideos();
            Obj.id_video = id_video;
            Obj.id_usuario = id_usuario;
            Obj.fecha_inicial = fecha_final;
            Obj.fecha_final = fecha_final;

            return Datos.Insertar_Videos(Obj);
        }


        // Funcion para eliminar prestamos de videos
        public static string Eliminar_Videos(int id_prestamo)
        {
            DPrestamos Datos = new DPrestamos();

            return Datos.Eliminar_Videos(id_prestamo);
        }
    }
}
