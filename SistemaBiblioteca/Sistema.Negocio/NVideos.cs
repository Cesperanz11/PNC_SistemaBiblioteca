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
    }
}
