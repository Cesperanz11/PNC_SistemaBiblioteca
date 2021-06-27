using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class PrestamoVideos
    {
        //Creando las variables que actuaran como los atributos de la tabla Prestamos de Videos
        public int id_video { set; get; }

        public int id_usuario { set; get; }

        public DateTime fecha_inicial { set; get; }

        public DateTime fecha_final { set; get; }

    }
}
