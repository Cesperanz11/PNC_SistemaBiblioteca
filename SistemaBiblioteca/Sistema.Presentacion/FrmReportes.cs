using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        //Funcion de Mensaje de Error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            cmbReporte.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (cmbReporte.SelectedIndex)
            {
                //Caso que seleccione Libros
                case 0:
                    Reportes.FrmReporteLibros ReporteL = new Reportes.FrmReporteLibros();
                    ReporteL.ShowDialog();
                    break;
                //Caso que seleccione Videos
                case 1:
                    Reportes.FrmReporteVideos ReporteV = new Reportes.FrmReporteVideos();
                    ReporteV.ShowDialog();
                    break;
                //Caso que seleccione Prestamos de Libros
                case 2:
                    Reportes.FrmPrestamosLibros ReportePL = new Reportes.FrmPrestamosLibros();
                    ReportePL.ShowDialog();
                    break;
                //Caso que seleccione Prestamos de Videos
                case 3:
                    Reportes.FrmPrestamosVideos ReporteVL = new Reportes.FrmPrestamosVideos();
                    ReporteVL.ShowDialog();
                    break;
                default:
                    this.MensajeError("Seleccione una opcion de reporte valida");
                    break;
            }
        }
    }
}
