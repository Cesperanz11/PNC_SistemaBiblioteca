using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Usuario
    {
        //Creando las variables que actuaran como los atributos de la tabla Usuario
        public int id_usuario { set; get; }

        public string nombre { set; get; }

        public string apellido { set; get; }

        public string telefono { set; get; }

        public string email { set; get; }

        public bool estdo { set; get; }

        public int id_rol { set; get; }
    }
}
