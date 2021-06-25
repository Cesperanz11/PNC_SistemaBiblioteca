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

        private void prestamosDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TPSelectL_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.Listar_Libros(); //Funcion para cargar el contenido de la tabla Libros
            this.Listar_Videos(); //Funcion para cargar e contenido de la tabla Videos

        }

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar_L();
            //Esto hace que el Tab General donde estan las Tabs muestre la columna 0, es decir, el "Listado de Libros"
            TabControl.SelectedIndex = 0;
        }

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

        private void BtnCancelarV_Click(object sender, EventArgs e)
        {
            this.Limpiar_V();
            //Esto hace que el Tab General donde estan las tabs muestre la columna 4, es decir, el "Listado de Videos"
            TabControl.SelectedIndex = 4;
        }
    }
}
