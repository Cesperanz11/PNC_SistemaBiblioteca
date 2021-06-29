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
using System.Data;

using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmDevolucion : Form
    {
        public FrmDevolucion()
        {
            InitializeComponent();
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


        //Funcion para dar formato a las devoluciones de libros mostrados
        private void FormatoPL()
        {
            dgvDevolucionLP.Columns[0].Width = 125;
            dgvDevolucionLP.Columns[1].Width = 125;
            dgvDevolucionLP.Columns[4].Visible = false;
            dgvDevolucionLP.Columns[5].Visible = false;

        }

        //Funcion para dar formato a las devoluciones de videos mostrados
        private void FormatoPV()
        {
            dgvDevolucionVP.Columns[0].Width = 125;
            dgvDevolucionVP.Columns[1].Width = 125;
            dgvDevolucionVP.Columns[4].Visible = false;
            dgvDevolucionVP.Columns[5].Visible = false;

        }




        //Funcion para buscar y regresar un maestro e imprimirlo en Devolucion Libros
        private void BuscarML()
        {

            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvDevolucionLM.DataSource = NUsuario.Listar(TxtFraseL.Text);

                //Aqui le daremos formato al DataSource
                //FormatoM();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Funcion para buscar y regresar un maestro e imprimirlo en Prestamo Videos
        private void BuscarMV()
        {

            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvDevolucionVM.DataSource = NUsuario.Listar(TxtFraseV.Text);

                //Aqui le daremos formato al DataSource
                //FormatoM();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Funcion para saber si se tienen filas de DataGridView seleccionadas
        private int SeleccionarFila(DataGridView dgv)
        {
            //Para saber si en realidad si esta haciendo la verificacion
            int fila = 0;

            if (dgv.SelectedRows.Count > 0)
            {

                fila = dgv.CurrentRow.Index;

                return fila;
            }
            else
            {
                return fila;
            }


        }








        //Funcion que se ejecuta al cargar la ventana
        private void FrmDevolucion_Load(object sender, EventArgs e)
        {

            //Sirve para setear las opciones por default  de devoluciones_libros al cargar la ventana
            dgvDevolucionLM.DataSource = null;
            dgvDevolucionLP.DataSource = null;
            dgvDevolucionLM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevolucionLP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Sirve para setear las opciones por default  de devoluciones_videos al cargar la ventana
            dgvDevolucionVM.DataSource = null;
            dgvDevolucionVP.DataSource = null;
            dgvDevolucionVM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevolucionVP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }






        //Boton de Buscar en pestania Devolucion de Libros
        private void BtnBuscarL_Click(object sender, EventArgs e)
        {
            if (TxtFraseL.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese un nombre o apellido antes de querer buscar un maestro");
                dgvDevolucionLM.DataSource = null;
            }
            else
            {
                string Rpta = "";

                Rpta = NUsuario.Existe_P(TxtFraseL.Text);

                if (Rpta.Equals("OK"))
                {

                    this.BuscarML();


                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }

        //Boton de Devolucion en pestania Devolucion de Libros
        private void BtnGuardarL_Click(object sender, EventArgs e)
        {

            //Guardando la fila que esta actualmente seleccionada
            int filaM = SeleccionarFila(dgvDevolucionLM);
            int filaP = SeleccionarFila(dgvDevolucionLP);


            //Guardando el DataTable que se habia mandado a buscar en el dgv de Maestros
            DataTable maestros = NUsuario.Listar(TxtFraseL.Text);


            //Guardando el ID de la fila actualmente seleccionada en dgv Maestros
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]);




            //Guardando el DataTable que se habia mandado a buscar en el dgv de Prestamos activos
            DataTable prestamos = NPrestamos.Listar_Libros(id_usuario);

            //Guardando el ID de la fila actualmente seleccionada en dgv Prestamos activos
            int id_prestamo = Convert.ToInt32(prestamos.Rows[filaP]["ID"]);


            //Guardando el Id_Libro de la fila actualmente seleccionada en dgv Prestamos activos
            int id_libro = Convert.ToInt32(prestamos.Rows[filaP]["ID_Libro"]);



            //Logica de verificar campos antes de ingresar prestamo

            if (dgvDevolucionLM.DataSource == null || dgvDevolucionLP.DataSource == null) // Este escenario es si ninguna fila a sido seleccionada aun o si el DGV esta vacio
            {
                this.MensajeError("Seleccione las filas necesarias para hacer la devolucion");
            }
            else // Aqui ya se han seleccionado ambas filas, tanto de Maestros como de Prestamos Activos
            {

                try
                {
                    string Rpta = "";


                    Rpta = NPrestamos.Eliminar_Libros(id_prestamo);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se devolvio de forma correcta el libro");
                        //Se regresan los dgv en limpio
                        dgvDevolucionLM.DataSource = null;
                        dgvDevolucionLP.DataSource = null;

                        //Se activa el libro que se registro en el prestamo
                        NLibros.Activar(id_libro);

                        TxtFraseL.Clear();

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
        }



        //Funcion que verifica el cambio de fila seleccionada en dgvMaestros en Devolucion de Libros

        private void dgvDevolucionLM_SelectionChanged(object sender, EventArgs e)
        {


            //Guardando la fila que esta actualmente seleccionada
            int filaM = SeleccionarFila(dgvDevolucionLM);

            //Guardando el DataTable que se habia mandado a buscar en el dgv
            DataTable maestros = NUsuario.Listar(TxtFraseL.Text);


            //Guardando el ID de la fila actualmente seleccionada
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]);

            try
            {
                //Obteniendo la tabla de la BD
                dgvDevolucionLP.DataSource = NPrestamos.Listar_Libros(id_usuario);

                //Aplicando el formato a la tabla para mejor disenio
                this.FormatoPL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }






        //Boton de Buscar en pestania Devolucion de Videos
        private void BtnBuscarV_Click(object sender, EventArgs e)
        {
            if (TxtFraseV.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese un nombre o apellido antes de querer buscar un maestro");
                dgvDevolucionLM.DataSource = null;
            }
            else
            {
                string Rpta = "";

                Rpta = NUsuario.Existe_P(TxtFraseV.Text);

                if (Rpta.Equals("OK"))
                {

                    this.BuscarMV();


                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }



        //Boton de Devolucion en pestania Devolucion de Videos
        private void BtnGuardarV_Click(object sender, EventArgs e)
        {


            //Guardando la fila que esta actualmente seleccionada
            int filaM = SeleccionarFila(dgvDevolucionVM);
            int filaP = SeleccionarFila(dgvDevolucionVP);


            //Guardando el DataTable que se habia mandado a buscar en el dgv de Maestros
            DataTable maestros = NUsuario.Listar(TxtFraseV.Text);


            //Guardando el ID de la fila actualmente seleccionada en dgv Maestros
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]);




            //Guardando el DataTable que se habia mandado a buscar en el dgv de Prestamos activos
            DataTable prestamos = NPrestamos.Listar_Videos(id_usuario);

            //Guardando el ID de la fila actualmente seleccionada en dgv Prestamos activos
            int id_prestamo = Convert.ToInt32(prestamos.Rows[filaP]["ID"]);


            //Guardando el Id_Libro de la fila actualmente seleccionada en dgv Prestamos activos
            int id_video = Convert.ToInt32(prestamos.Rows[filaP]["ID_Video"]);



            //Logica de verificar campos antes de ingresar prestamo

            if (dgvDevolucionVM.DataSource == null || dgvDevolucionVP.DataSource == null) // Este escenario es si ninguna fila a sido seleccionada aun o si el DGV esta vacio
            {
                this.MensajeError("Seleccione las filas necesarias para hacer la devolucion");
            }
            else // Aqui ya se han seleccionado ambas filas, tanto de Maestros como de Prestamos Activos
            {

                try
                {
                    string Rpta = "";


                    Rpta = NPrestamos.Eliminar_Videos(id_prestamo);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se devolvio de forma correcta el video prestado");
                        //Se regresan los dgv en limpio
                        dgvDevolucionVM.DataSource = null;
                        dgvDevolucionVP.DataSource = null;

                        //Se activa el libro que se registro en el prestamo
                        NLibros.Activar(id_video);

                        TxtFraseV.Clear();

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
        }



        //Funcion que verifica el cambio de fila seleccionada en dgvMaestros en Devolucion de Videos
        private void dgvDevolucionVM_SelectionChanged(object sender, EventArgs e)
        {


            //Guardando la fila que esta actualmente seleccionada
            int filaM = SeleccionarFila(dgvDevolucionVM);

            //Guardando el DataTable que se habia mandado a buscar en el dgv
            DataTable maestros = NUsuario.Listar(TxtFraseV.Text);


            //Guardando el ID de la fila actualmente seleccionada
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]);

            try
            {
                //Obteniendo la tabla de la BD
                dgvDevolucionVP.DataSource = NPrestamos.Listar_Videos(id_usuario);

                //Aplicando el formato a la tabla para mejor disenio
                this.FormatoPV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
