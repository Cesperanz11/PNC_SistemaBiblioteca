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
    public partial class FrmPrestamosVideos : Form
    {
        public FrmPrestamosVideos()
        {
            InitializeComponent();
        }

        private void FrmPrestamosVideos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.prestamosvideos_reportes' Puede moverla o quitarla según sea necesario.
            this.prestamosvideos_reportesTableAdapter.Fill(this.DsSistema.prestamosvideos_reportes);

            this.reportViewer1.RefreshReport();
        }
    }
}
