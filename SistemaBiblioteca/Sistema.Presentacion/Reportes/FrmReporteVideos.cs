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
    public partial class FrmReporteVideos : Form
    {
        public FrmReporteVideos()
        {
            InitializeComponent();
        }

        private void FrmReporteVideos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.videos_reportes' Puede moverla o quitarla según sea necesario.
            this.videos_reportesTableAdapter.Fill(this.DsSistema.videos_reportes);

            this.reportViewer1.RefreshReport();
        }
    }
}
