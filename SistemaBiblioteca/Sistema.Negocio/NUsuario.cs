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
    public class NUsuario
    {
        // Funcion de login
        public static string Login(string Email, string Password)
        {
            //Utiizando funcion para verificar que no se haya ingesado anteriormente
            DUsuario Datos = new DUsuario();
            string Existe = Datos.Login(Email, Password);

            //validando que el login a la BD es exitoso
            if (Existe.Equals("0")) // Si la contraseña no coincide, retornaremos un mensaje que lo indique
            {
                return "La contraseña es incorrecta";
            }
            else
            {
                //Si la contraseña si coincide, es correcta y se completara el login
                return "OK";
            }
        }

        //Funcion de verificar existencia de usuario
        public static string Verificar(string Email)
        {
            //Utiizando funcion para verificar que no se haya ingesado anteriormente
            DUsuario Datos = new DUsuario();
            string Existe = Datos.Existe(Email);

            //validando que el usuario ingresado exista en la BD
            if (Existe.Equals("0")) // Si el usuario no existe, retornaremos un mensaje que lo indique
            {
                return "El usuario no existe";
            }
            else
            {
                //Si el usuario ya existe, se continua el proceso
                return "OK";
            }
        }

        // Funcion de listar usuarios (maestros)
        public static DataTable Listar()
        {
            //Se utiliza la funcion de la clase Datos para obtener la informacion
            DUsuario Datos = new DUsuario();
            return Datos.Listar();
        }
    }
}
