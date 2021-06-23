using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    class Videos
    {
        //Creando las variables que actuaran como los atributos de la tabla Videos

        public int id_video { set; get; }

        public string titulo { set; get; }

        public string director { set; get; }

        public string productora { set; get; }

        public string tipo { set; get; }

        public int anio { set; get; }

        public int duracion { set; get; }

        public string pais { set; get; }

        public string idioma { set; get; }

        public string subtitulos { set; get; }

        public string clasificacion { set; get; }

        public string genero { set; get; }

        public string sinopsis { set; get; }

        public string ubicacion { set; get; }

        public string hola { set; get; }
    }
}
