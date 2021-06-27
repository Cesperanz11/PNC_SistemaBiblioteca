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
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        //Funcion para Listar Libros
        private void ListarPrestamos_Libros()
        {
            try
            {
                //Obteniendo la tabla de la BD
                dgvPrestamoLL.DataSource = NLibros.Listar();

                //Aplicando el formato a la tabla para mejor disenio
                // this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Funcion para listar videos
        private void ListarPrestamos_Videos()
        {
            try
            {
                //Obteniendo la tabla de la BD
                //dgvPrestamoVL.DataSource = NVideos.Listar();

                //Aplicando el formato a la tabla para mejor disenio
                // this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        //Funcion de Mensaje de Error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Funcion de Mensaje de OK
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //Funcion para buscar y regresar un libro e imprimirlo
        private void BuscarL()
        {
         
            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvPrestamoLL.DataSource = NLibros.Buscar(TxtFraseL.Text, cmbLibro.SelectedIndex);
                
                //Aqui le daremos formato al DataSource
                // FormatoL();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }







        //Funcion que se ejecuta al cargar la ventana
        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            cmbLibro.SelectedIndex = 1;
            dgvPrestamoLL.DataSource = null;
            dgvPrestamoLM.DataSource = null;
            dgvPrestamoLP.DataSource = null;
        }


        //Boton de Buscar un Libro en pestania Prestamo de Libros
        private void BtnBuscarL_Click(object sender, EventArgs e)
        {
            if (TxtFraseL.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese una frase antes de querer buscar un libro");
            }
            else
            {
                string Rpta = "";

                Rpta = NLibros.Existe(TxtFraseL.Text);

                if (Rpta.Equals("OK"))
                {
                    this.BuscarL();

                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        
        }
    }
}
