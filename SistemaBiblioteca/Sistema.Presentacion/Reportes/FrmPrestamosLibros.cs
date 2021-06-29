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
    public partial class FrmPrestamosLibros : Form
    {
        public FrmPrestamosLibros()
        {
            InitializeComponent();
        }

        private void FrmPrestamosLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.prestamoslibros_reportes' Puede moverla o quitarla según sea necesario.
            this.prestamoslibros_reportesTableAdapter.Fill(this.DsSistema.prestamoslibros_reportes);

            this.reportViewer1.RefreshReport();
        }
    }
}
