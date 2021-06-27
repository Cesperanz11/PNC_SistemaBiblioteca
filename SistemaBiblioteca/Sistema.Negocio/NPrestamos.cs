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
        public static DataTable Listar_Libros(int id_libro, int id_usuario)
        {
            //Se utiliza la funcion de la clase Datos para obtener la informacion
            DPrestamos Datos = new DPrestamos();
            return Datos.Listar_Libros(id_libro, id_usuario);
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
            Obj.fecha_inicial = fecha_final;
            Obj.fecha_final = fecha_final;

            return Datos.Insertar_Libros(Obj);
        }
    }
}
