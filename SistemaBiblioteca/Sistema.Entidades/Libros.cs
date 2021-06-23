using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    class Libros
    {
        //Creando las variables que actuaran como los atributos de la tabla Libros

        public int id_libro { set; get; }

        public int numero_ejemplares { set; get; }

        public string isbn { set; get; }

        public string titulo { set; get; }

        public string autor { set; get; }

        public string editorial { set; get; }

        public int anio_edicion { set; get; }

        public string numero_edicion { set; get; }

        public string pais { set; get; }

        public string idioma { set; get; }

        public string materia { set; get; }

        public int numero_pagina { set; get; }

        public string ubicacion { set; get; }

        public string descripcion { set; get; }

    }
}
