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
    public class NLibros
    {
        // Funcion de listar libros
        public static DataTable Listar()
        {
            //Se utiliza la funcion de la clase Datos para obtener la informacion
            DLibros Datos = new DLibros();
            return Datos.Listar();
        }
    }
}
