using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmMaestros : Form
    {
        public FrmMaestros()
        {
            InitializeComponent();
        }

        // Funcion para listar libros
        private void Listar_Libros()
        {
            try
            {
                //Obteniendo la tabla de la BD
                dgvLibros.DataSource = NLibros.Listar();

                //Aplicando el formato a la tabla para mejor disenio
                // this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Funcion para listar videos
        private void Listar_Videos()
        {
            try
            {
                //Obteniendo la tabla de la BD
                dgvVideo.DataSource = NVideos.Listar();

                //Aplicando el formato a la tabla para mejor disenio
                // this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        // Funcion para buscar libros
        private void BuscarL()
        {
            try
            {
                dgvLibros.DataSource = NLibros.Buscar(TxtSearchL.Text, cmbLibros.SelectedIndex );
                //this.Formato();
                //LblTotal.Text = "Total de registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Funcion para buscar Videos
        private void BuscarV()
        {
            try
            {
                dgvVideo.DataSource = NVideos.Buscar(TxtSearchV.Text, cmbVideos.SelectedIndex);
                //this.Formato();
                //LblTotal.Text = "Total de registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Boton de busqueda de Libros
        private void BtnBuscarL_Click(object sender, EventArgs e)
        {
            this.BuscarL();
        }

        // Funcion que carga todo al iniciar el Form
        private void FrmMaestros_Load(object sender, EventArgs e)
        {
            this.Listar_Libros();
            cmbLibros.SelectedIndex = 1;
            this.Listar_Videos();
            cmbVideos.SelectedIndex = 0;

        }

        // Boton de buscar Videos
        private void BtnBuscarV_Click(object sender, EventArgs e)
        {
            this.BuscarV();
        }
    }
}
