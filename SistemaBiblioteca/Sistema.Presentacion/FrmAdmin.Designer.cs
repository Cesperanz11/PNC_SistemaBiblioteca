
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
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.videosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.videosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TPSelectL = new System.Windows.Forms.TabPage();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TPSelectL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.tabControl1.SuspendLayout();
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
            this.prestamosDeLibrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.videosToolStripMenuItem});
            this.prestamosDeLibrosToolStripMenuItem.Name = "prestamosDeLibrosToolStripMenuItem";
            this.prestamosDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosDeLibrosToolStripMenuItem.Text = "Prestamos";
            this.prestamosDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.prestamosDeLibrosToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // videosToolStripMenuItem
            // 
            this.videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            this.videosToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.videosToolStripMenuItem.Text = "Videos";
            // 
            // devolucionDeLibrosToolStripMenuItem
            // 
            this.devolucionDeLibrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem1,
            this.videosToolStripMenuItem1});
            this.devolucionDeLibrosToolStripMenuItem.Name = "devolucionDeLibrosToolStripMenuItem";
            this.devolucionDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.devolucionDeLibrosToolStripMenuItem.Text = "Devoluciones";
            // 
            // librosToolStripMenuItem1
            // 
            this.librosToolStripMenuItem1.Name = "librosToolStripMenuItem1";
            this.librosToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.librosToolStripMenuItem1.Text = "Libros";
            // 
            // videosToolStripMenuItem1
            // 
            this.videosToolStripMenuItem1.Name = "videosToolStripMenuItem1";
            this.videosToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.videosToolStripMenuItem1.Text = "Videos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem2,
            this.videosToolStripMenuItem2,
            this.prestamosLibrosToolStripMenuItem,
            this.prestamosVideosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // librosToolStripMenuItem2
            // 
            this.librosToolStripMenuItem2.Name = "librosToolStripMenuItem2";
            this.librosToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.librosToolStripMenuItem2.Text = "Libros";
            // 
            // videosToolStripMenuItem2
            // 
            this.videosToolStripMenuItem2.Name = "videosToolStripMenuItem2";
            this.videosToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.videosToolStripMenuItem2.Text = "Videos";
            // 
            // prestamosLibrosToolStripMenuItem
            // 
            this.prestamosLibrosToolStripMenuItem.Name = "prestamosLibrosToolStripMenuItem";
            this.prestamosLibrosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.prestamosLibrosToolStripMenuItem.Text = "Prestamos libros";
            // 
            // prestamosVideosToolStripMenuItem
            // 
            this.prestamosVideosToolStripMenuItem.Name = "prestamosVideosToolStripMenuItem";
            this.prestamosVideosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.prestamosVideosToolStripMenuItem.Text = "Prestamos videos";
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
            this.TPInsertarL.Location = new System.Drawing.Point(4, 22);
            this.TPInsertarL.Name = "TPInsertarL";
            this.TPInsertarL.Padding = new System.Windows.Forms.Padding(3);
            this.TPInsertarL.Size = new System.Drawing.Size(624, 317);
            this.TPInsertarL.TabIndex = 1;
            this.TPInsertarL.Text = "Ingresar Libros";
            this.TPInsertarL.UseVisualStyleBackColor = true;
            // 
            // TPSelectL
            // 
            this.TPSelectL.Controls.Add(this.dgvLista);
            this.TPSelectL.Location = new System.Drawing.Point(4, 22);
            this.TPSelectL.Name = "TPSelectL";
            this.TPSelectL.Padding = new System.Windows.Forms.Padding(3);
            this.TPSelectL.Size = new System.Drawing.Size(624, 317);
            this.TPSelectL.TabIndex = 0;
            this.TPSelectL.Text = "Consultar Libros";
            this.TPSelectL.UseVisualStyleBackColor = true;
            this.TPSelectL.Click += new System.EventHandler(this.TPSelectL_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(4, 42);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(617, 269);
            this.dgvLista.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPSelectL);
            this.tabControl1.Controls.Add(this.TPInsertarL);
            this.tabControl1.Controls.Add(this.TPActualizarL);
            this.tabControl1.Controls.Add(this.TPEliminarL);
            this.tabControl1.Location = new System.Drawing.Point(0, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 343);
            this.tabControl1.TabIndex = 4;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.tabControl1);
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
            this.TPSelectL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem prestamosLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosVideosToolStripMenuItem;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.TabPage TPEliminarL;
        private System.Windows.Forms.TabPage TPActualizarL;
        private System.Windows.Forms.TabPage TPInsertarL;
        private System.Windows.Forms.TabPage TPSelectL;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TabControl tabControl1;
    }
}



