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

        //Funcion para determinar existencia de libro
        public static string Existe(string isbn)
        {
            DLibros Datos = new DLibros();
            string Rpta = "";

            Rpta = Datos.Existe(isbn);
            if (Rpta.Equals("0") || isbn.Equals(""))
            {
                return "El dato que se ha consultado no existe en la BD";
            }
            else 
            {
                return "OK";
            }
            
        }


        //Funcion para determinar existencia de libro en pestania prestamos
        public static string Existe_P(string dato, int type)
        {
            DLibros Datos = new DLibros();
            string Rpta = "";

            Rpta = Datos.Existe_P(dato, type);
            if (Rpta.Equals("0"))
            {
                return "El dato que se ha consultado no existe en la BD";
            }
            else
            {
                return "OK";
            }

        }



        // Funcion para insertar libros
        public static string Insertar(int num_ejemplares, string isbn, string titulo, string autor, 
            string editorial, int anio_edicion, string num_edicion, string pais, string idioma, 
            string materia, int num_pagina, string ubicacion, string descripcion)
        {
            //Utiizando funcion para verificar que no se haya ingesado anteriormente
            DLibros Datos = new DLibros();
            string Existe = Datos.Existe(isbn);

            //validando que el nuevo libro ingresado no exista en la BD
            if (Existe.Equals("1"))
            {
                return "El libro ya existe";
            }
            else
            {
                //si no existe se asigna los valores al objeto para posteriormente ejecutarlo
                Libros Obj = new Libros();
                Obj.numero_ejemplares = num_ejemplares;
                Obj.isbn = isbn;
                Obj.titulo = titulo;
                Obj.autor = autor;
                Obj.editorial = editorial;
                Obj.anio_edicion = anio_edicion;
                Obj.numero_edicion = num_edicion; 
                Obj.pais = pais;
                Obj.idioma = idioma;
                Obj.materia = materia;
                Obj.numero_pagina = num_pagina;
                Obj.ubicacion = ubicacion;
                Obj.descripcion = descripcion;

                return Datos.Insertar(Obj);
            }
        }

        // Funcion para buscar libros
        public static DataTable Buscar(string Valor, int criterio)
        {
            DLibros Datos = new DLibros();

            return Datos.Buscar(Valor, criterio);
        }

        // Funcion para actualizar libros
        public static string Actualizar(int num_ejemplares, string isbn, string titulo, string autor,
            string editorial, int anio_edicion, string num_edicion, string pais, string idioma,
            string materia, int num_pagina, string ubicacion, string descripcion)
        {
            DLibros Datos = new DLibros();
            Libros Obj = new Libros();

            //Como ponemos a disposicion del admin todos los campos y sus valores, el es responsable de mandar la info de manera
            //correcta y ya editada
            //Mandamos en un objetvo Libros todos los parametros.
            Obj.numero_ejemplares = num_ejemplares;
            Obj.isbn = isbn;
            Obj.titulo = titulo;
            Obj.autor = autor;
            Obj.editorial = editorial;
            Obj.anio_edicion = anio_edicion;
            Obj.numero_edicion = num_edicion;
            Obj.pais = pais;
            Obj.idioma = idioma;
            Obj.materia = materia;
            Obj.numero_pagina = num_pagina;
            Obj.ubicacion = ubicacion;
            Obj.descripcion = descripcion;

            return Datos.Actualizar(Obj);
        }

        // Funcion para eliminar libros
        public static string Eliminar(string isbn)
        {
            DLibros Datos = new DLibros();

            return Datos.Eliminar(isbn);
        }
    }
}
