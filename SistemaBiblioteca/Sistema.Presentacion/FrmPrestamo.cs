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


        //Funcion de validar fecha
        private string CompararFecha(DateTime fecha_ingresada, DateTime fecha_actual)
        {
            int resultado = DateTime.Compare(fecha_ingresada, fecha_actual);
            string Rpta ="";

            if (resultado <= 0)
                return Rpta  = "Ingrese una fecha que no sea menor o igual a la fecha actual";
            else
                return Rpta = "OK";
        }


        //Funcion para dar formato a los libros mostrados
        private void FormatoL()
        {
            dgvPrestamoLL.Columns[0].Width = 80;
            dgvPrestamoLL.Columns[1].Width = 100;
            dgvPrestamoLL.Columns[2].Width = 100;
            dgvPrestamoLL.Columns[3].Width = 120;
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

        //Funcion para dar formato a los prestamos de libros mostrados
        private void FormatoPL()
        {
            dgvPrestamoLP.Columns[0].Width = 125;
            dgvPrestamoLP.Columns[1].Width = 125;
            dgvPrestamoLP.Columns[4].Visible = false;
            dgvPrestamoLP.Columns[5].Visible = false;

        }


        //Funcion para dar formato a los prestamos de videos mostrados
        private void FormatoPV()
        {
            dgvPrestamoVP.Columns[0].Width = 125;
            dgvPrestamoVP.Columns[1].Width = 125;
            dgvPrestamoVP.Columns[4].Visible = false;
            dgvPrestamoVP.Columns[5].Visible = false;

        }



        private string ComprobarEstado( int estado )
        {
            string Rpta = "";

            if(estado == 1)
            {
                return Rpta = "OK";
            }
            else
            {
                return Rpta = "Lo que se ha solicitado no esta disponible para prestamo";
            }
        }


        //Funcion para saber si se tienen filas de DataGridView seleccionadas
        private int SeleccionarFila(DataGridView dgv)
        {
            //Para saber si en realidad si esta haciendo la verificacion
            int fila = 0;

            if(dgv.SelectedRows.Count > 0 ) {

                fila = dgv.CurrentRow.Index;

                return fila;
            }
            else 
            { 
               return fila; 
            }
            

        }

        //Funcion para buscar y regresar un libro e imprimirlo
        private void BuscarL()
        {
         
            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvPrestamoLL.DataSource = NLibros.BuscarActivos(TxtFraseL.Text, cmbLibro.SelectedIndex);
                
                //Aqui le daremos formato al DataSource
                this.FormatoL();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Funcion para buscar y regresar un video e imprimirlo
        private void BuscarV()
        {

            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvPrestamoVV.DataSource = NVideos.Buscar(TxtFraseV.Text, cmbVideo.SelectedIndex);

                //Aqui le daremos formato al DataSource
                //this.FormatoL();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Funcion para buscar y regresar un maestro e imprimirlo en Prestamo Libros
        private void BuscarML()
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


        //Funcion para buscar y regresar un maestro e imprimirlo en Prestamo Videos
        private void BuscarMV()
        {

            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                dgvPrestamoVM.DataSource = NUsuario.Listar(TxtMaestroV.Text);

                //Aqui le daremos formato al DataSource
                //FormatoM();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }







        //Funcion que se ejecuta al cargar la ventana
        private void FrmPrestamo_Load(object sender, EventArgs e)
        {

            //Sirve para setear las opciones por default  de prestamos_libros al cargar la ventana
            cmbLibro.SelectedIndex = 1;
            dgvPrestamoLL.DataSource = null;
            dgvPrestamoLM.DataSource = null;
            dgvPrestamoLP.DataSource = null;
            dgvPrestamoLL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamoLM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamoLP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtpLibro.Value = DateTime.Today;

            //Sirve para setear las opciones por default  de prestamos_videos al cargar la ventana
            cmbVideo.SelectedIndex = 0;
            dgvPrestamoVV.DataSource = null;
            dgvPrestamoVM.DataSource = null;
            dgvPrestamoVP.DataSource = null;
            dgvPrestamoVV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamoVM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamoVP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtpVideo.Value = DateTime.Today;


        }







        //Boton de Buscar un Libro en pestania Prestamo de Libros
        private void BtnBuscarL_Click(object sender, EventArgs e)
        {
            if (TxtFraseL.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese una frase o palabra antes de querer buscar un libro");
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

                    this.BuscarML();
                    

                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }

        //Boton de Registrar Prestamo en pestania Prestamo de Libros
        private void BtnGuardarL_Click(object sender, EventArgs e)
        {
            

            //Guardando la fila que esta actualmente seleccionada
            int filaL = SeleccionarFila(dgvPrestamoLL);
            int filaM = SeleccionarFila(dgvPrestamoLM);


            //Guardando el DataTable que se habia mandado a buscar en el dgv
            DataTable libros = NLibros.Buscar(TxtFraseL.Text, cmbLibro.SelectedIndex);
            DataTable maestros = NUsuario.Listar(TxtMaestroL.Text);


            //Guardando el ID de la fila actualmente seleccionada
            int id_libro = Convert.ToInt32(libros.Rows[filaL]["codigo"]);
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]); 



            //Logica de verificar campos antes de ingresar prestamo

            if ( dgvPrestamoLL.DataSource == null || dgvPrestamoLM.DataSource == null ) // Este escenario es si ninguna fila a sido seleccionada aun o si el DGV esta vacio
            { 
                this.MensajeError("Seleccione las filas necesarias para hacer el prestamo (libro y maestro)");
            }
            else // Aqui ya se han seleccionado ambas filas, tanto de Libros como de Maestros
            {

                DateTime hoy = DateTime.Today;
                string resultado_fecha = this.CompararFecha(dtpLibro.Value, hoy);


                if(dtpLibro.Checked == false) //Aqui se verifica si no hay fecha seleccionada
                {
                    this.MensajeError("Seleccione una fecha antes de ingresar el prestamo");
                }
                else if ( resultado_fecha.Equals("OK") ) //Este es el escenario con una fecha valida seleccionada
                {

                    try
                    {
                        string Rpta = "";


                        Rpta = NPrestamos.Insertar_Libros(id_libro,id_usuario, hoy, dtpLibro.Value);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se ingreso de forma correcta el prestamo del libro en el registro");
                            //Se regresan los dgv en limpio
                            dgvPrestamoLL.DataSource = null;
                            dgvPrestamoLM.DataSource = null;
                            dgvPrestamoLP.DataSource = null;

                            dtpLibro.Value = DateTime.Today;
                            

                            //Se desactiva el libro que se registro en el prestamo
                            //NLibros.Desactivar(id_libro);

                            TxtFraseL.Clear();
                            TxtMaestroL.Clear();

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
                else  //Esto es por si la fecha es menor o igual a la fecha actual, por ende no es valida
                {
                    this.MensajeError(resultado_fecha);
                }
            }
        }



        //Funcion que verifica el cambio de fila seleccionada en dgvMaestros en Prestamos de Libros
        private void dgvPrestamoLM_SelectionChanged(object sender, EventArgs e)
        {

            //Guardando la fila que esta actualmente seleccionada
            int filaM = SeleccionarFila(dgvPrestamoLM);

            //Guardando el DataTable que se habia mandado a buscar en el dgv
            DataTable maestros = NUsuario.Listar(TxtMaestroL.Text);


            //Guardando el ID de la fila actualmente seleccionada
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]);

            try
            {
                //Obteniendo la tabla de la BD
                dgvPrestamoLP.DataSource = NPrestamos.Listar_Libros(id_usuario);

                //Aplicando el formato a la tabla para mejor disenio
                this.FormatoPL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        
    }




        //Boton de Buscar un Video en pestania Prestamo de Videos
        private void BtnBuscarV_Click(object sender, EventArgs e)
        {
            if (TxtFraseV.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese una frase o palabra antes de querer buscar un video");
                dgvPrestamoVV.DataSource = null;
            }
            else
            {
                string Rpta = "";

                Rpta = NVideos.Existe_P(TxtFraseV.Text,  cmbVideo.SelectedIndex );

                if (Rpta.Equals("OK"))
                {
                    this.BuscarV();

                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }

        //Boton de Buscar un Maestro en pestania Prestamo de Videos
        private void BtnBuscarMV_Click(object sender, EventArgs e)
        {
            if (TxtMaestroV.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese un nombre o apellido antes de querer buscar un maestro");
                dgvPrestamoVM.DataSource = null;
            }
            else
            {
                string Rpta = "";

                Rpta = NUsuario.Existe_P(TxtMaestroV.Text);

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

        //Boton de Registrar Prestamo en pestania Prestamo de Videos
        private void BtnGuardarV_Click(object sender, EventArgs e)
        {


            //Guardando la fila que esta actualmente seleccionada
            int filaV = SeleccionarFila(dgvPrestamoVV);
            int filaM = SeleccionarFila(dgvPrestamoVM);


            //Guardando el DataTable que se habia mandado a buscar en el dgv
            DataTable videos = NVideos.Buscar(TxtFraseV.Text, cmbVideo.SelectedIndex);
            DataTable maestros = NUsuario.Listar(TxtMaestroV.Text);


            //Guardando el ID de la fila actualmente seleccionada
            int id_video = Convert.ToInt32(videos.Rows[filaV]["codigo"]);
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]);



            //Logica de verificar campos antes de ingresar prestamo

            if ( dgvPrestamoVV.DataSource == null || dgvPrestamoVM.DataSource == null) // Este escenario es si ninguna fila a sido seleccionada aun o si el DGV esta vacio
            {
                this.MensajeError("Seleccione las filas necesarias para hacer el prestamo (video y maestro)");
            }
            else // Aqui ya se han seleccionado ambas filas, tanto de Libros como de Maestros
            {

                DateTime hoy = DateTime.Today;
                string resultado_fecha = this.CompararFecha(dtpVideo.Value, hoy);


                if (dtpVideo.Checked == false) //Aqui se verifica si no hay fecha seleccionada
                {
                    this.MensajeError("Seleccione una fecha antes de ingresar el prestamo");
                }
                else if (resultado_fecha.Equals("OK")) //Este es el escenario con una fecha valida seleccionada
                {

                    try
                    {
                        string Rpta = "";


                        Rpta = NPrestamos.Insertar_Videos(id_video, id_usuario, hoy, dtpVideo.Value);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se ingreso de forma correcta el prestamo del video en el registro");
                            //Se regresa los dgv en limpio
                            dgvPrestamoVV.DataSource = null;
                            dgvPrestamoVM.DataSource = null;
                            dgvPrestamoVP.DataSource = null;

                            TxtFraseV.Clear();
                            TxtMaestroV.Clear();

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
                else  //Esto es por si la fecha es menor o igual a la fecha actual, por ende no es valida
                {
                    this.MensajeError(resultado_fecha);
                }
            }
        }



        //Funcion que verifica el cambio de fila seleccionada en dgvMaestros en Prestamos de Videos
        private void dgvPrestamoVM_SelectionChanged(object sender, EventArgs e)
        {

            //Guardando la fila que esta actualmente seleccionada
            int filaM = SeleccionarFila(dgvPrestamoVM);

            //Guardando el DataTable que se habia mandado a buscar en el dgv
            DataTable maestros = NUsuario.Listar(TxtMaestroV.Text);


            //Guardando el ID de la fila actualmente seleccionada
            int id_usuario = Convert.ToInt32(maestros.Rows[filaM]["codigo"]);

            try
            {
                //Obteniendo la tabla de la BD
                dgvPrestamoVP.DataSource = NPrestamos.Listar_Videos(id_usuario);

                //Aplicando el formato a la tabla para mejor disenio
                this.FormatoPV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void FrmPrestamo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FrmAdmin.ActiveForm.Show();
        }
    }
}
