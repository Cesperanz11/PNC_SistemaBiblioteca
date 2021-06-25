
namespace Sistema.Presentacion
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.prestamosDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LblAdmin = new System.Windows.Forms.Label();
            this.TPEliminarL = new System.Windows.Forms.TabPage();
            this.TPActualizarL = new System.Windows.Forms.TabPage();
            this.TPInsertarL = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPaisL = new System.Windows.Forms.TextBox();
            this.TxtIdiomaL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUbiL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAnioEdicion = new System.Windows.Forms.TextBox();
            this.TxtNumEdicion = new System.Windows.Forms.TextBox();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtTituloL = new System.Windows.Forms.TextBox();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TPSelectL = new System.Windows.Forms.TabPage();
            this.dgvListaLibros = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TPSelectV = new System.Windows.Forms.TabPage();
            this.dgvListaVideos = new System.Windows.Forms.DataGridView();
            this.TPInsertarV = new System.Windows.Forms.TabPage();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.TxtNumPaginas = new System.Windows.Forms.TextBox();
            this.TxtNumEjemplares = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TPInsertarL.SuspendLayout();
            this.TPSelectL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibros)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TPSelectV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosDeLibrosToolStripMenuItem,
            this.devolucionDeLibrosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // prestamosDeLibrosToolStripMenuItem
            // 
            this.prestamosDeLibrosToolStripMenuItem.Name = "prestamosDeLibrosToolStripMenuItem";
            this.prestamosDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosDeLibrosToolStripMenuItem.Text = "Prestamos";
            this.prestamosDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.prestamosDeLibrosToolStripMenuItem_Click);
            // 
            // devolucionDeLibrosToolStripMenuItem
            // 
            this.devolucionDeLibrosToolStripMenuItem.Name = "devolucionDeLibrosToolStripMenuItem";
            this.devolucionDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.devolucionDeLibrosToolStripMenuItem.Text = "Devoluciones";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel.Text = "Proyecto Final PNC";
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(12, 62);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(608, 20);
            this.LblAdmin.TabIndex = 5;
            this.LblAdmin.Text = "Bienvenido al Sistema de Administracion de la Biblioteca Central";
            // 
            // TPEliminarL
            // 
            this.TPEliminarL.Location = new System.Drawing.Point(4, 22);
            this.TPEliminarL.Name = "TPEliminarL";
            this.TPEliminarL.Size = new System.Drawing.Size(624, 317);
            this.TPEliminarL.TabIndex = 3;
            this.TPEliminarL.Text = "Eliminar Libros";
            this.TPEliminarL.UseVisualStyleBackColor = true;
            // 
            // TPActualizarL
            // 
            this.TPActualizarL.Location = new System.Drawing.Point(4, 22);
            this.TPActualizarL.Name = "TPActualizarL";
            this.TPActualizarL.Size = new System.Drawing.Size(624, 317);
            this.TPActualizarL.TabIndex = 2;
            this.TPActualizarL.Text = "Actualizar Libros";
            this.TPActualizarL.UseVisualStyleBackColor = true;
            // 
            // TPInsertarL
            // 
            this.TPInsertarL.Controls.Add(this.BtnCancelar);
            this.TPInsertarL.Controls.Add(this.BtnIngresar);
            this.TPInsertarL.Controls.Add(this.TxtNumEjemplares);
            this.TPInsertarL.Controls.Add(this.TxtNumPaginas);
            this.TPInsertarL.Controls.Add(this.TxtMateria);
            this.TPInsertarL.Controls.Add(this.label13);
            this.TPInsertarL.Controls.Add(this.label12);
            this.TPInsertarL.Controls.Add(this.label11);
            this.TPInsertarL.Controls.Add(this.TxtPaisL);
            this.TPInsertarL.Controls.Add(this.TxtIdiomaL);
            this.TPInsertarL.Controls.Add(this.label10);
            this.TPInsertarL.Controls.Add(this.label9);
            this.TPInsertarL.Controls.Add(this.TxtUbiL);
            this.TPInsertarL.Controls.Add(this.label8);
            this.TPInsertarL.Controls.Add(this.TxtAnioEdicion);
            this.TPInsertarL.Controls.Add(this.TxtNumEdicion);
            this.TPInsertarL.Controls.Add(this.TxtEditorial);
            this.TPInsertarL.Controls.Add(this.TxtAutor);
            this.TPInsertarL.Controls.Add(this.TxtTituloL);
            this.TPInsertarL.Controls.Add(this.TxtIsbn);
            this.TPInsertarL.Controls.Add(this.TxtDescripcion);
            this.TPInsertarL.Controls.Add(this.label7);
            this.TPInsertarL.Controls.Add(this.label6);
            this.TPInsertarL.Controls.Add(this.label5);
            this.TPInsertarL.Controls.Add(this.label4);
            this.TPInsertarL.Controls.Add(this.label3);
            this.TPInsertarL.Controls.Add(this.label2);
            this.TPInsertarL.Controls.Add(this.label1);
            this.TPInsertarL.Location = new System.Drawing.Point(4, 22);
            this.TPInsertarL.Name = "TPInsertarL";
            this.TPInsertarL.Padding = new System.Windows.Forms.Padding(3);
            this.TPInsertarL.Size = new System.Drawing.Size(624, 317);
            this.TPInsertarL.TabIndex = 1;
            this.TPInsertarL.Text = "Ingresar Libros";
            this.TPInsertarL.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Numero de ejemplares:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Numero de paginas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Materia:";
            // 
            // TxtPaisL
            // 
            this.TxtPaisL.Location = new System.Drawing.Point(415, 149);
            this.TxtPaisL.Name = "TxtPaisL";
            this.TxtPaisL.Size = new System.Drawing.Size(200, 20);
            this.TxtPaisL.TabIndex = 19;
            // 
            // TxtIdiomaL
            // 
            this.TxtIdiomaL.Location = new System.Drawing.Point(415, 174);
            this.TxtIdiomaL.Name = "TxtIdiomaL";
            this.TxtIdiomaL.Size = new System.Drawing.Size(200, 20);
            this.TxtIdiomaL.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Idioma:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pais:";
            // 
            // TxtUbiL
            // 
            this.TxtUbiL.Location = new System.Drawing.Point(415, 123);
            this.TxtUbiL.Name = "TxtUbiL";
            this.TxtUbiL.Size = new System.Drawing.Size(200, 20);
            this.TxtUbiL.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ubicacion:";
            // 
            // TxtAnioEdicion
            // 
            this.TxtAnioEdicion.Location = new System.Drawing.Point(116, 152);
            this.TxtAnioEdicion.Name = "TxtAnioEdicion";
            this.TxtAnioEdicion.Size = new System.Drawing.Size(87, 20);
            this.TxtAnioEdicion.TabIndex = 13;
            // 
            // TxtNumEdicion
            // 
            this.TxtNumEdicion.Location = new System.Drawing.Point(116, 126);
            this.TxtNumEdicion.Name = "TxtNumEdicion";
            this.TxtNumEdicion.Size = new System.Drawing.Size(156, 20);
            this.TxtNumEdicion.TabIndex = 12;
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(72, 100);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(200, 20);
            this.TxtEditorial.TabIndex = 11;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(72, 73);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(200, 20);
            this.TxtAutor.TabIndex = 10;
            // 
            // TxtTituloL
            // 
            this.TxtTituloL.Location = new System.Drawing.Point(72, 44);
            this.TxtTituloL.Name = "TxtTituloL";
            this.TxtTituloL.Size = new System.Drawing.Size(238, 20);
            this.TxtTituloL.TabIndex = 9;
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(72, 19);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(131, 20);
            this.TxtIsbn.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(415, 19);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(200, 98);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Año de Edicion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de Edicion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editorial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // TPSelectL
            // 
            this.TPSelectL.Controls.Add(this.dgvListaLibros);
            this.TPSelectL.Location = new System.Drawing.Point(4, 22);
            this.TPSelectL.Name = "TPSelectL";
            this.TPSelectL.Padding = new System.Windows.Forms.Padding(3);
            this.TPSelectL.Size = new System.Drawing.Size(624, 317);
            this.TPSelectL.TabIndex = 0;
            this.TPSelectL.Text = "Consultar Libros";
            this.TPSelectL.UseVisualStyleBackColor = true;
            this.TPSelectL.Click += new System.EventHandler(this.TPSelectL_Click);
            // 
            // dgvListaLibros
            // 
            this.dgvListaLibros.AllowUserToAddRows = false;
            this.dgvListaLibros.AllowUserToDeleteRows = false;
            this.dgvListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLibros.Location = new System.Drawing.Point(4, 0);
            this.dgvListaLibros.Name = "dgvListaLibros";
            this.dgvListaLibros.ReadOnly = true;
            this.dgvListaLibros.Size = new System.Drawing.Size(617, 311);
            this.dgvListaLibros.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TPSelectL);
            this.TabControl.Controls.Add(this.TPInsertarL);
            this.TabControl.Controls.Add(this.TPActualizarL);
            this.TabControl.Controls.Add(this.TPEliminarL);
            this.TabControl.Controls.Add(this.TPSelectV);
            this.TabControl.Controls.Add(this.TPInsertarV);
            this.TabControl.Location = new System.Drawing.Point(0, 85);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(632, 343);
            this.TabControl.TabIndex = 4;
            // 
            // TPSelectV
            // 
            this.TPSelectV.Controls.Add(this.dgvListaVideos);
            this.TPSelectV.Location = new System.Drawing.Point(4, 22);
            this.TPSelectV.Name = "TPSelectV";
            this.TPSelectV.Size = new System.Drawing.Size(624, 317);
            this.TPSelectV.TabIndex = 4;
            this.TPSelectV.Text = "Consultar Videos";
            this.TPSelectV.UseVisualStyleBackColor = true;
            // 
            // dgvListaVideos
            // 
            this.dgvListaVideos.AllowUserToAddRows = false;
            this.dgvListaVideos.AllowUserToDeleteRows = false;
            this.dgvListaVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVideos.Location = new System.Drawing.Point(0, 3);
            this.dgvListaVideos.Name = "dgvListaVideos";
            this.dgvListaVideos.ReadOnly = true;
            this.dgvListaVideos.Size = new System.Drawing.Size(624, 311);
            this.dgvListaVideos.TabIndex = 0;
            // 
            // TPInsertarV
            // 
            this.TPInsertarV.Location = new System.Drawing.Point(4, 22);
            this.TPInsertarV.Name = "TPInsertarV";
            this.TPInsertarV.Size = new System.Drawing.Size(624, 317);
            this.TPInsertarV.TabIndex = 5;
            this.TPInsertarV.Text = "Ingresar Videos";
            this.TPInsertarV.UseVisualStyleBackColor = true;
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(116, 189);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(194, 20);
            this.TxtMateria.TabIndex = 23;
            // 
            // TxtNumPaginas
            // 
            this.TxtNumPaginas.Location = new System.Drawing.Point(116, 215);
            this.TxtNumPaginas.Name = "TxtNumPaginas";
            this.TxtNumPaginas.Size = new System.Drawing.Size(131, 20);
            this.TxtNumPaginas.TabIndex = 24;
            // 
            // TxtNumEjemplares
            // 
            this.TxtNumEjemplares.Location = new System.Drawing.Point(131, 242);
            this.TxtNumEjemplares.Name = "TxtNumEjemplares";
            this.TxtNumEjemplares.Size = new System.Drawing.Size(116, 20);
            this.TxtNumEjemplares.TabIndex = 25;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(315, 262);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(142, 23);
            this.BtnIngresar.TabIndex = 26;
            this.BtnIngresar.Text = "Ingresar Libro";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(474, 262);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(142, 23);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Biblioteca (Administracion)";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TPInsertarL.ResumeLayout(false);
            this.TPInsertarL.PerformLayout();
            this.TPSelectL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibros)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TPSelectV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem prestamosDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.TabPage TPEliminarL;
        private System.Windows.Forms.TabPage TPActualizarL;
        private System.Windows.Forms.TabPage TPInsertarL;
        private System.Windows.Forms.TabPage TPSelectL;
        private System.Windows.Forms.DataGridView dgvListaLibros;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TPSelectV;
        private System.Windows.Forms.DataGridView dgvListaVideos;
        private System.Windows.Forms.TabPage TPInsertarV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUbiL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAnioEdicion;
        private System.Windows.Forms.TextBox TxtNumEdicion;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtTituloL;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPaisL;
        private System.Windows.Forms.TextBox TxtIdiomaL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtNumEjemplares;
        private System.Windows.Forms.TextBox TxtNumPaginas;
        private System.Windows.Forms.TextBox TxtMateria;
    }
}



