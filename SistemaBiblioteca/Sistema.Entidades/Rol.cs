using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    class Rol
    {
        //Creando las variables que actuaran como los atributos de la tabla Rol
        public int id_rol { set; get; }

        public string nombre { set; get; }

        public string descripcion { set; get; }

        public bool estado { set; get; }

    }
}
