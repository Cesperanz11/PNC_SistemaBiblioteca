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

        private void BtnBuscarL_Click(object sender, EventArgs e)
        {
            this.BuscarL();
        }

        private void FrmMaestros_Load(object sender, EventArgs e)
        {
            this.Listar_Libros();
            cmbLibros.SelectedIndex = 1;

        }
    }
}
