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

namespace Sistema.Presentacion
{
    public partial class FrmAdmin : Form
    {
        private int childFormNumber = 0;

        public FrmAdmin()
        {
            InitializeComponent();
        }


        //Funcion para listar libros
        private void Listar_Libros()
        {
            try
            {
                //Obteniendo la tabla de la BD
                dgvListaLibros.DataSource = NLibros.Listar();

                //Aplicando el formato a la tabla para mejor disenio
                // this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Funcion para listar videos
        private void Listar_Videos()
        {
            try
            {
                //Obteniendo la tabla de la BD
                dgvListaVideos.DataSource = NVideos.Listar();

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



        //Funcion de Limpiar formulario de ingresar Libros
        private void Limpiar_L()
        {
            TxtIsbn.Clear();
            TxtTituloL.Clear();
            TxtAutor.Clear();
            TxtEditorial.Clear();
            TxtNumEdicion.Clear();
            TxtAnioEdicion.Clear();
            TxtMateria.Clear();
            TxtNumPaginas.Clear();
            TxtNumEjemplares.Clear();
            TxtDescripcion.Clear();
            TxtUbiL.Clear();
            TxtPaisL.Clear();
            TxtIdiomaL.Clear();
        }

        //Funcion de Limpiar formulario de actualizar Libros
        private void Limpiar_LAct()
        {
            TxtIsbn_.Clear();
            TxtTituloL_.Clear();
            TxtAutor_.Clear();
            TxtEditorial_.Clear();
            TxtNumEdicion_.Clear();
            TxtAnio_.Clear();
            TxtMateria_.Clear();
            TxtNumPagina_.Clear();
            TxtNumEjemplares_.Clear();
            TxtDescripcion_.Clear();
            TxtUbiL_.Clear();
            TxtPaisL_.Clear();
            TxtIdiomaL_.Clear();
        }

        //Funcion de Limpiar formulario de ingresar Videos
        private void Limpiar_V()
        {
            TxtTituloV.Clear();
            TxtDirector.Clear();
            TxtProd.Clear();
            TxtTipo.Clear();
            TxtAnio.Clear();
            TxtDuracion.Clear();
            TxtPaisV.Clear();
            TxtIdiomaV.Clear();
            TxtSubs.Clear();
            TxtClasificacion.Clear();
            TxtGenero.Clear();
            TxtSinopsis.Clear();
            TxtUbiV.Clear();
        }

        //Funcion de Limpiar formulario de actualizar Videos
        private void Limpiar_VAct()
        {
            TxtId_.Clear();
            TxtTituloV_.Clear();
            TxtDirector_.Clear();
            TxtProductora_.Clear();
            TxtTipo_.Clear();
            TxtAnioV_.Clear();
            TxtDuracion_.Clear();
            TxtPaisV_.Clear();
            TxtIdiomaV_.Clear();
            TxtSubs_.Clear();
            TxtClasificacion_.Clear();
            TxtGenero_.Clear();
            TxtSinopsis_.Clear();
            TxtUbiV_.Clear();
        }




        //Funcion para ocultar textboxes de Actualizar Libros
        private void OcultarLibros()
        {
            //Esto hara que cada textbox no aparezca hasta que lo indiquemos
            TxtTituloL_.Visible = false;
            TxtAutor_.Visible = false;
            TxtEditorial_.Visible = false;
            TxtNumEdicion_.Visible = false;
            TxtAnio_.Visible = false;
            TxtMateria_.Visible = false;
            TxtNumPagina_.Visible = false;
            TxtNumEjemplares_.Visible = false;
            TxtDescripcion_.Visible = false;
            TxtUbiL_.Visible = false;
            TxtPaisL_.Visible = false;
            TxtIdiomaL_.Visible = false;
        }

        //Funcion para mostar textboxes de Actualizar Videos
        private void MostrarLibros()
        {
            //Esto hara que cada textbox no aparezca hasta que lo indiquemos
            TxtTituloL_.Visible = true;
            TxtAutor_.Visible = true;
            TxtEditorial_.Visible = true;
            TxtNumEdicion_.Visible = true;
            TxtAnio_.Visible = true;
            TxtMateria_.Visible = true;
            TxtNumPagina_.Visible = true;
            TxtNumEjemplares_.Visible = true;
            TxtDescripcion_.Visible = true;
            TxtUbiL_.Visible = true;
            TxtPaisL_.Visible = true;
            TxtIdiomaL_.Visible = true;
        }


        //Funcion para ocultar textboxes de Actualizar Videos
        private void OcultarVideos()
        {
            //Esto hara que cada textbox no aparezca hasta que lo indiquemos
            TxtTituloV_.Visible = false;
            TxtDirector_.Visible = false;
            TxtProductora_.Visible = false;
            TxtTipo_.Visible = false;
            TxtAnioV_.Visible = false; 
            TxtDuracion_.Visible = false; 
            TxtPaisV_.Visible = false; 
            TxtIdiomaV_.Visible = false; 
            TxtSubs_.Visible = false; 
            TxtClasificacion_.Visible = false; 
            TxtGenero_.Visible = false; 
            TxtSinopsis_.Visible = false; 
            TxtUbiV_.Visible = false; 
        }

        //Funcion para mostar textboxes de Actualizar Videos
        private void MostrarVideos()
        {
            //Esto hara que cada textbox no aparezca hasta que lo indiquemos
            TxtTituloV_.Visible = true;
            TxtDirector_.Visible = true;
            TxtProductora_.Visible = true;
            TxtTipo_.Visible = true;
            TxtAnioV_.Visible = true;
            TxtDuracion_.Visible = true;
            TxtPaisV_.Visible = true;
            TxtIdiomaV_.Visible = true;
            TxtSubs_.Visible = true;
            TxtClasificacion_.Visible = true ;
            TxtGenero_.Visible = true;
            TxtSinopsis_.Visible = true;
            TxtUbiV_.Visible = true;
        }




        //Funcion para actualizar libros
        private void Actualizar_L()
        {
            try
            {
                string Rpta = "";


                Rpta = NLibros.Actualizar(Convert.ToInt32(TxtNumEjemplares_.Text.Trim()), TxtIsbn_.Text.Trim(), TxtTituloL_.Text.Trim(),
                       TxtAutor_.Text.Trim(), TxtEditorial_.Text.Trim(), Convert.ToInt32(TxtAnio_.Text.Trim()), TxtNumEdicion_.Text.Trim(),
                        TxtPaisL_.Text.Trim(), TxtIdiomaL_.Text.Trim(), TxtMateria_.Text.Trim(), Convert.ToInt32(TxtNumPagina_.Text.Trim()),
                        TxtUbiL_.Text.Trim(), TxtDescripcion_.Text.Trim());
                if (Rpta.Equals("OK"))
                {
                    this.MensajeOk("Se actualizo de forma correcta el libro en el registro");
                    this.Limpiar_LAct();
                    this.Listar_Libros();
                    //Se regresa a la tab de "Listado de Libros"
                    TabControl.SelectedIndex = 0;
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

        //Funcion para actualizar videos
        private void Actualizar_V()
        {
            try
            {
                string Rpta = "";


                Rpta = NVideos.Actualizar(Convert.ToInt32(TxtId_.Text.Trim()) ,TxtTituloV_.Text.Trim(), TxtDirector_.Text.Trim(), TxtProductora_.Text.Trim(),
                    TxtTipo_.Text.Trim(), Convert.ToInt32(TxtAnioV_.Text.Trim()), Convert.ToInt32(TxtDuracion_.Text.Trim()),
                    TxtPaisV_.Text.Trim(), TxtIdiomaV_.Text.Trim(), TxtSubs_.Text.Trim(),
                    TxtClasificacion_.Text.Trim(), TxtGenero_.Text.Trim(), TxtSinopsis_.Text.Trim(),
                    TxtUbiV_.Text.Trim());
                if (Rpta.Equals("OK"))
                {
                    this.MensajeOk("Se actualizo de forma correcta el video en el registro");
                    this.Limpiar_VAct();
                    this.Listar_Videos();
                    //Se regresa a la tab de "Listado de Videos"
                    TabControl.SelectedIndex = 4;
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



        //Funcion para buscar y regresar un libro al actualizar e imprimirlo
        private void BuscarL()
        {
            DataTable libro = new DataTable();
            
            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                libro = NLibros.Buscar(TxtIsbn_.Text, 0);
                //Asignando al texto de Actualizar Libro su valor correspondiente, identificandolo con su nombre de alias (establecido en la BD)
                TxtTituloL_.Text = libro.Rows[0]["titulo"].ToString();
                TxtAutor_.Text = libro.Rows[0]["autor(es)"].ToString();
                TxtEditorial_.Text = libro.Rows[0]["editorial"].ToString();
                TxtAnio_.Text = libro.Rows[0]["año edicion"].ToString();
                TxtNumEdicion_.Text = libro.Rows[0]["numero edicion"].ToString();
                TxtNumEjemplares_.Text = libro.Rows[0]["ejemplares"].ToString();
                TxtPaisL_.Text = libro.Rows[0]["pais"].ToString();
                TxtIdiomaL_.Text = libro.Rows[0]["idioma"].ToString();
                TxtMateria_.Text = libro.Rows[0]["materia"].ToString();
                TxtNumPagina_.Text = libro.Rows[0]["paginas"].ToString();
                TxtUbiL_.Text = libro.Rows[0]["ubicacion"].ToString();
                TxtDescripcion_.Text = libro.Rows[0]["descripcion"].ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Funcion para buscar y regresar un video al actualizar e imprimirlo
        private void BuscarV()
        {
            DataTable video = new DataTable();

            try
            {
                //Aqui recuperara un DataTable con el Select que cumple la condicion de busqueda
                video = NVideos.Obtener(Convert.ToInt32(TxtId_.Text));
                //Asignando al texto de Actualizar Libro su valor correspondiente, identificandolo con su nombre de alias (establecido en la BD)
                TxtTituloV_.Text = video.Rows[0]["titulo"].ToString();
                TxtDirector_.Text = video.Rows[0]["director(es)"].ToString();
                TxtProductora_.Text = video.Rows[0]["productora"].ToString();
                TxtAnioV_.Text = video.Rows[0]["año"].ToString();
                TxtDuracion_.Text = video.Rows[0]["duracion"].ToString();
                TxtSubs_.Text = video.Rows[0]["subtitulos"].ToString();
                TxtPaisV_.Text = video.Rows[0]["pais"].ToString();
                TxtIdiomaV_.Text = video.Rows[0]["idioma"].ToString();
                TxtGenero_.Text = video.Rows[0]["género"].ToString();
                TxtClasificacion_.Text = video.Rows[0]["clasificación"].ToString();
                TxtUbiV_.Text = video.Rows[0]["ubicacion"].ToString();
                TxtSinopsis_.Text = video.Rows[0]["sinopsis"].ToString();
                TxtTipo_.Text = video.Rows[0]["tipo"].ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }




        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //Funcion para crear el FrmPrestamos
        public static void ThreadProcPrestamo()
        {
            FrmPrestamo f;
            Application.Run(new FrmPrestamo());
        }


        //Funcion de pasar el control a FrmPrestamos
        private void prestamosDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcPrestamo));
            t.Start();
            this.Close();
        }

        private void TPSelectL_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.Listar_Libros(); //Funcion para cargar el contenido de la tabla Libros
            this.Listar_Videos(); //Funcion para cargar e contenido de la tabla Videos
            this.OcultarLibros(); //Funcion para ocultar los textbox de la pestania actualizar libros
            this.OcultarVideos(); //Funcion para ocultar los textbox de la pestania actualizar videos
            BtnActualizarL.Visible = false;
            BtnActualizarV.Visible = false;
            BtnEliminarEL.Visible = false;
            BtnEliminarEV.Visible = false;

        }

        //Boton de Ingresar de pestania Insertar Libros
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtIsbn.Text == string.Empty || TxtTituloL.Text == string.Empty || TxtAutor.Text == string.Empty
                    || TxtEditorial.Text == string.Empty || TxtNumEdicion.Text == string.Empty || TxtAnioEdicion.Text == string.Empty
                    || TxtMateria.Text == string.Empty || TxtNumPaginas.Text == string.Empty || TxtNumEjemplares.Text == string.Empty
                    || TxtDescripcion.Text == string.Empty || TxtUbiL.Text == string.Empty || TxtPaisL.Text == string.Empty
                    || TxtIdiomaL.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos que deben ser obligatorios.");
                    //ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                }
                else
                {
                    Rpta = NLibros.Insertar( Convert.ToInt32(TxtNumEjemplares.Text.Trim()) , TxtIsbn.Text.Trim(), TxtTituloL.Text.Trim(),
                        TxtAutor.Text.Trim(), TxtEditorial.Text.Trim(), Convert.ToInt32(TxtAnioEdicion.Text.Trim()), TxtNumEdicion.Text.Trim(),
                        TxtPaisL.Text.Trim(), TxtIdiomaL.Text.Trim(), TxtMateria.Text.Trim(), Convert.ToInt32(TxtNumPaginas.Text.Trim()),
                        TxtUbiL.Text.Trim(), TxtDescripcion.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ingreso el libro de forma correcta en el registro");
                        this.Limpiar_L();
                        this.Listar_Libros();
                        //Esto hace que el Tab General donde estan las Tabs muestre la columna 0, es decir, el "Listado de Libros"
                        TabControl.SelectedIndex = 0;

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Boton de Cancelar de pestania Insertar Libros
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar_L();
            //Esto hace que el Tab General donde estan las Tabs muestre la columna 0, es decir, el "Listado de Libros"
            TabControl.SelectedIndex = 0;
        }




        //Boton de Ingresar de pestania Insertar Videos
        private void BtnIngresarV_Click(object sender, EventArgs e)
        {

            try
            {
                string Rpta = "";
                if (TxtTituloV.Text == string.Empty || TxtDirector.Text == string.Empty || TxtProd.Text == string.Empty
                    || TxtTipo.Text == string.Empty || TxtAnio.Text == string.Empty || TxtDuracion.Text == string.Empty
                    || TxtPaisV.Text == string.Empty || TxtIdiomaV.Text == string.Empty || TxtSubs.Text == string.Empty
                    || TxtClasificacion.Text == string.Empty || TxtGenero.Text == string.Empty || TxtSinopsis.Text == string.Empty
                    || TxtUbiV.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos que deben ser obligatorios.");
                    //ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                }
                else
                {
                    Rpta = NVideos.Insertar(TxtTituloV.Text.Trim(), TxtDirector.Text.Trim(), TxtProd.Text.Trim(),
                    TxtTipo.Text.Trim(), Convert.ToInt32(TxtAnio.Text.Trim()), Convert.ToInt32(TxtDuracion.Text.Trim()),
                    TxtPaisV.Text.Trim(), TxtIdiomaV.Text.Trim(), TxtSubs.Text.Trim(),
                    TxtClasificacion.Text.Trim(), TxtGenero.Text.Trim(), TxtSinopsis.Text.Trim(),
                    TxtUbiV.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ingreso el video de forma correcta en el registro");
                        this.Limpiar_V();
                        this.Listar_Videos();
                        //Esto hace que el Tab General donde estan las Tabs muestre la columna 4, es decir, el "Listado de Videos"
                        TabControl.SelectedIndex = 4;

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Boton de Cancelar de pestania Insertar Videos
        private void BtnCancelarV_Click(object sender, EventArgs e)
        {
            this.Limpiar_V();
            //Esto hace que el Tab General donde estan las tabs muestre la columna 4, es decir, el "Listado de Videos"
            TabControl.SelectedIndex = 4;
        }




        //Boton de Buscar de pestania Actualizar Libros
        private void BtnBuscarL__Click(object sender, EventArgs e)
        {
            string Rpta = "";

            Rpta = NLibros.Existe(TxtIsbn_.Text);

            if (Rpta.Equals("OK"))
            {
                this.BuscarL();
                this.MostrarLibros();
                BtnActualizarL.Visible = true;

            }
            else
            {
                this.MensajeError(Rpta);
            }
        }

        //Boton de Actualizar de pestania Actualizar Libros
        private void BtnActualizarL_Click(object sender, EventArgs e)
        {
            if (TxtIsbn_.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese un ISBN de libro antes de querer actualizar");
            }
            else
            {

                this.Actualizar_L();
                this.OcultarLibros();
                BtnActualizarL.Visible = false;
            }

        }

        //Boton de Cancelar de pestania Actualizar Libros
        private void BtnCancelarL__Click(object sender, EventArgs e) 
        {
            this.Limpiar_LAct();
            this.OcultarLibros();
            BtnActualizarL.Visible = false;
            TabControl.SelectedIndex = 0;
        }




        //Boton de Buscar de pestania Actualizar Videos
        private void BtnBuscarV__Click(object sender, EventArgs e)
        {
            if (TxtId_.Text.Equals(""))
            {
                this.MensajeError("El ID de video que se ha consultado no existe en la BD");
            }
            else
            {
                string Rpta = "";

                Rpta = NVideos.BuscarID(Convert.ToInt32(TxtId_.Text));

                if (Rpta.Equals("OK"))
                {
                    this.BuscarV();
                    this.MostrarVideos();
                    BtnActualizarV.Visible = true;

                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }

        //Boton de Actualizar de pestania Actualizar Videos
        private void BtnActualizarV_Click(object sender, EventArgs e)
        {
            if (TxtId_.Text.Equals(""))
            {
                this.MensajeError("Primero ingrese un id de video antes de querer actualizar");
            }
            else
            {
                
                this.Actualizar_V();
                this.OcultarVideos();
                BtnActualizarV.Visible = false;
            }
            
        }

        //Boton de Cancelar de pestania Actualizar Videos
        private void BtnCancelarV__Click(object sender, EventArgs e)
        {
            this.Limpiar_VAct();
            this.OcultarVideos();
            BtnActualizarV.Visible = false;
            TabControl.SelectedIndex = 4;
        }


        //Boton de Buscar de pestania Eliminar Libros
        private void BtnBuscarEL_Click(object sender, EventArgs e)
        {
            string Rpta = "";

            Rpta = NLibros.Existe(TxtIsbnEL.Text.Trim().ToString());

            if (Rpta.Equals("OK"))
            {
                dgvEliminarL.DataSource = NLibros.Buscar(TxtIsbnEL.Text.Trim().ToString(), 0);
                BtnEliminarEL.Visible = true;

            }
            else
            {
                this.MensajeError(Rpta);
            }
        }

        //Boton de Eliminar de pestania Eliminar Libros
        private void BtnEliminarEL_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar este libro?", "Sistema de Biblioteca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {

                    NLibros.Eliminar(TxtIsbnEL.Text.Trim().ToString());
                    TxtIsbnEL.Clear();
                    dgvEliminarL.DataSource = null;
                    this.Listar_Libros();
                    BtnEliminarEL.Visible = false;
                    TabControl.SelectedIndex = 0;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        //Boton de Cancelar de pestania Eliminar Libros
        private void BtnCancelarEL_Click(object sender, EventArgs e)
        {
            TxtIsbnEL.Clear();
            dgvEliminarL.DataSource = null;
            this.Listar_Libros();
            BtnEliminarEL.Visible = false;
            TabControl.SelectedIndex = 0;
        }


        //Boton de Buscar de pestania Eliminar Videos
        private void BtnBuscarEV_Click(object sender, EventArgs e)
        {
            if (TxtIdEV.Text.Equals(""))
            {
                this.MensajeError("El ID de video que se ha consultado no existe en la BD");
            }
            else
            {
                string Rpta = "";

                Rpta = NVideos.BuscarID(Convert.ToInt32(TxtIdEV.Text));

                if (Rpta.Equals("OK"))
                {
                    dgvEliminarV.DataSource = NVideos.Obtener(Convert.ToInt32(TxtIdEV.Text));
                    BtnEliminarEV.Visible = true;

                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }

        //Boton de Eliminar de pestania Eliminar Videos
        private void BtnEliminarEV_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar este video?", "Sistema de Biblioteca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {

                    NVideos.Eliminar(Convert.ToInt32(TxtIdEV.Text));
                    TxtIdEV.Clear();
                    dgvEliminarV.DataSource = null;
                    this.Listar_Videos();
                    BtnEliminarEV.Visible = false;
                    TabControl.SelectedIndex = 4;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Boton de Cancelar de pestania Eliminar Videos
        private void BtnCancelarEV_Click(object sender, EventArgs e)
        {
            TxtIdEV.Clear();
            dgvEliminarV.DataSource = null;
            this.Listar_Videos();
            BtnEliminarEV.Visible = false;
            TabControl.SelectedIndex = 4;
        }
    }
}
