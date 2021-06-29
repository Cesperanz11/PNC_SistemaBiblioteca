using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmReporteLibros : Form
    {
        public FrmReporteLibros()
        {
            InitializeComponent();
        }

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.libros_reporte' Puede moverla o quitarla según sea necesario.
            this.libros_reporteTableAdapter.Fill(this.DsSistema.libros_reporte);

            this.reportViewer1.RefreshReport();
        }
    }
}
