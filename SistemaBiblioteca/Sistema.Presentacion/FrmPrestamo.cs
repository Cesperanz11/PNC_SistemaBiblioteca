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


        //Funcion para dar formato a los libros mostrados
        private void FormatoL()
        {
            dgvPrestamoLL.Columns[0].Width = 80;
            dgvPrestamoLL.Columns[1].Width = 100;
            dgvPrestamoLL.Columns[2].Width = 100;
            dgvPrestamoLL.Columns[3].Width = 100;
            dgvPrestamoLL.Columns[4].Visible = false;
            dgvPrestamoLL.Columns[5].Visible = false;
            dgvPrestamoLL.Columns[6].Visible = false;
            dgvPrestamoLL.Columns[7].Visible = false;
            dgvPrestamoLL.Columns[8].Visible = false;
            dgvPrestamoLL.Columns[9].Visible = false;
            dgvPrestamoLL.Columns[10].Visible = false;
            dgvPrestamoLL.Columns[11].Visible = false;
            dgvPrestamoLL.Columns[12].Visible = false;
            dgvPrestamoLL.Columns[13].Visible = false;
        }

        //Funcion para dar formato a los maestros mostrados
        private void FormatoM()
        {
            dgvPrestamoLM.Columns[0].Width = 100;
            dgvPrestamoLM.Columns[1].Width = 100;
            dgvPrestamoLM.Columns[2].Width = 100;
        }




        //Funcion para buscar y regresar un libro e imprimirlo
        private void BuscarL()
        {
         
            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvPrestamoLL.DataSource = NLibros.Buscar(TxtFraseL.Text, cmbLibro.SelectedIndex);
                
                //Aqui le daremos formato al DataSource
                this.FormatoL();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Funcion para buscar y regresar un libro e imprimirlo
        private void BuscarM()
        {

            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvPrestamoLM.DataSource = NUsuario.Listar(TxtMaestroL.Text);

                //Aqui le daremos formato al DataSource
                FormatoM();

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
                dgvPrestamoLL.DataSource = null;
            }
            else
            {
                string Rpta = "";

                Rpta = NLibros.Existe_P(TxtFraseL.Text, cmbLibro.SelectedIndex);

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

        //Boton de Buscar un Maestro en pestania Prestamo de Libros
        private void BtnBuscarML_Click(object sender, EventArgs e)
        {
            if (TxtMaestroL.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese un nombre o apellido antes de querer buscar un maestro");
                dgvPrestamoLM.DataSource = null;
            }
            else
            {
                string Rpta = "";

                Rpta = NUsuario.Existe_P(TxtMaestroL.Text);

                if (Rpta.Equals("OK"))
                {

                    this.BuscarM();

                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }
    }
}
