
namespace Sistema.Presentacion
{
    partial class FrmPrestamo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPPrestamoL = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarML = new System.Windows.Forms.Button();
            this.dgvPrestamoLM = new System.Windows.Forms.DataGridView();
            this.dgvPrestamoLL = new System.Windows.Forms.DataGridView();
            this.BtnGuardarL = new System.Windows.Forms.Button();
            this.dtpLibro = new System.Windows.Forms.DateTimePicker();
            this.dgvPrestamoLP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMaestroL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.BtnBuscarL = new System.Windows.Forms.Button();
            this.TxtFraseL = new System.Windows.Forms.TextBox();
            this.TPPrestamoV = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBuscarMV = new System.Windows.Forms.Button();
            this.dgvPrestamoVM = new System.Windows.Forms.DataGridView();
            this.dgvPrestamoVV = new System.Windows.Forms.DataGridView();
            this.BtnGuardarV = new System.Windows.Forms.Button();
            this.dtpVideo = new System.Windows.Forms.DateTimePicker();
            this.dgvPrestamoVP = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMaestroV = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVideo = new System.Windows.Forms.ComboBox();
            this.BtnBuscarV = new System.Windows.Forms.Button();
            this.TxtFraseV = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TPPrestamoL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TPPrestamoV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoVP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPPrestamoL);
            this.tabControl1.Controls.Add(this.TPPrestamoV);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // TPPrestamoL
            // 
            this.TPPrestamoL.Controls.Add(this.label5);
            this.TPPrestamoL.Controls.Add(this.label1);
            this.TPPrestamoL.Controls.Add(this.BtnBuscarML);
            this.TPPrestamoL.Controls.Add(this.dgvPrestamoLM);
            this.TPPrestamoL.Controls.Add(this.dgvPrestamoLL);
            this.TPPrestamoL.Controls.Add(this.BtnGuardarL);
            this.TPPrestamoL.Controls.Add(this.dtpLibro);
            this.TPPrestamoL.Controls.Add(this.dgvPrestamoLP);
            this.TPPrestamoL.Controls.Add(this.groupBox1);
            this.TPPrestamoL.Controls.Add(this.groupBox2);
            this.TPPrestamoL.Location = new System.Drawing.Point(4, 22);
            this.TPPrestamoL.Name = "TPPrestamoL";
            this.TPPrestamoL.Padding = new System.Windows.Forms.Padding(3);
            this.TPPrestamoL.Size = new System.Drawing.Size(788, 423);
            this.TPPrestamoL.TabIndex = 0;
            this.TPPrestamoL.Text = "Prestamo Libros";
            this.TPPrestamoL.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Escoger fecha de devolucion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Prestamos activos del profesor seleccionado:";
            // 
            // BtnBuscarML
            // 
            this.BtnBuscarML.Location = new System.Drawing.Point(681, 45);
            this.BtnBuscarML.Name = "BtnBuscarML";
            this.BtnBuscarML.Size = new System.Drawing.Size(101, 26);
            this.BtnBuscarML.TabIndex = 18;
            this.BtnBuscarML.Text = "Buscar";
            this.BtnBuscarML.UseVisualStyleBackColor = true;
            this.BtnBuscarML.Click += new System.EventHandler(this.BtnBuscarML_Click);
            // 
            // dgvPrestamoLM
            // 
            this.dgvPrestamoLM.AllowUserToAddRows = false;
            this.dgvPrestamoLM.AllowUserToDeleteRows = false;
            this.dgvPrestamoLM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoLM.Location = new System.Drawing.Point(488, 83);
            this.dgvPrestamoLM.Name = "dgvPrestamoLM";
            this.dgvPrestamoLM.ReadOnly = true;
            this.dgvPrestamoLM.Size = new System.Drawing.Size(294, 124);
            this.dgvPrestamoLM.TabIndex = 17;
            this.dgvPrestamoLM.SelectionChanged += new System.EventHandler(this.dgvPrestamoLM_SelectionChanged);
            // 
            // dgvPrestamoLL
            // 
            this.dgvPrestamoLL.AllowUserToAddRows = false;
            this.dgvPrestamoLL.AllowUserToDeleteRows = false;
            this.dgvPrestamoLL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoLL.Location = new System.Drawing.Point(6, 83);
            this.dgvPrestamoLL.Name = "dgvPrestamoLL";
            this.dgvPrestamoLL.ReadOnly = true;
            this.dgvPrestamoLL.Size = new System.Drawing.Size(439, 124);
            this.dgvPrestamoLL.TabIndex = 16;
            // 
            // BtnGuardarL
            // 
            this.BtnGuardarL.Location = new System.Drawing.Point(550, 340);
            this.BtnGuardarL.Name = "BtnGuardarL";
            this.BtnGuardarL.Size = new System.Drawing.Size(200, 47);
            this.BtnGuardarL.TabIndex = 15;
            this.BtnGuardarL.Text = "Registrar Prestamo";
            this.BtnGuardarL.UseVisualStyleBackColor = true;
            this.BtnGuardarL.Click += new System.EventHandler(this.BtnGuardarL_Click);
            // 
            // dtpLibro
            // 
            this.dtpLibro.Location = new System.Drawing.Point(550, 281);
            this.dtpLibro.Name = "dtpLibro";
            this.dtpLibro.Size = new System.Drawing.Size(200, 20);
            this.dtpLibro.TabIndex = 14;
            // 
            // dgvPrestamoLP
            // 
            this.dgvPrestamoLP.AllowUserToAddRows = false;
            this.dgvPrestamoLP.AllowUserToDeleteRows = false;
            this.dgvPrestamoLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoLP.Location = new System.Drawing.Point(6, 247);
            this.dgvPrestamoLP.Name = "dgvPrestamoLP";
            this.dgvPrestamoLP.ReadOnly = true;
            this.dgvPrestamoLP.Size = new System.Drawing.Size(506, 168);
            this.dgvPrestamoLP.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMaestroL);
            this.groupBox1.Location = new System.Drawing.Point(474, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 215);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Maestro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre o Apellido:";
            // 
            // TxtMaestroL
            // 
            this.TxtMaestroL.Location = new System.Drawing.Point(14, 42);
            this.TxtMaestroL.Name = "TxtMaestroL";
            this.TxtMaestroL.Size = new System.Drawing.Size(175, 20);
            this.TxtMaestroL.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbLibro);
            this.groupBox2.Controls.Add(this.BtnBuscarL);
            this.groupBox2.Controls.Add(this.TxtFraseL);
            this.groupBox2.Location = new System.Drawing.Point(-2, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 215);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Criterio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Frase o palabra de busqueda:";
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Items.AddRange(new object[] {
            "ISBN",
            "Titulo",
            "Autor"});
            this.cmbLibro.Location = new System.Drawing.Point(236, 43);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(121, 21);
            this.cmbLibro.TabIndex = 12;
            // 
            // BtnBuscarL
            // 
            this.BtnBuscarL.Location = new System.Drawing.Point(363, 42);
            this.BtnBuscarL.Name = "BtnBuscarL";
            this.BtnBuscarL.Size = new System.Drawing.Size(101, 26);
            this.BtnBuscarL.TabIndex = 7;
            this.BtnBuscarL.Text = "Buscar";
            this.BtnBuscarL.UseVisualStyleBackColor = true;
            this.BtnBuscarL.Click += new System.EventHandler(this.BtnBuscarL_Click);
            // 
            // TxtFraseL
            // 
            this.TxtFraseL.Location = new System.Drawing.Point(8, 42);
            this.TxtFraseL.Name = "TxtFraseL";
            this.TxtFraseL.Size = new System.Drawing.Size(222, 20);
            this.TxtFraseL.TabIndex = 11;
            // 
            // TPPrestamoV
            // 
            this.TPPrestamoV.Controls.Add(this.label6);
            this.TPPrestamoV.Controls.Add(this.label7);
            this.TPPrestamoV.Controls.Add(this.BtnBuscarMV);
            this.TPPrestamoV.Controls.Add(this.dgvPrestamoVM);
            this.TPPrestamoV.Controls.Add(this.dgvPrestamoVV);
            this.TPPrestamoV.Controls.Add(this.BtnGuardarV);
            this.TPPrestamoV.Controls.Add(this.dtpVideo);
            this.TPPrestamoV.Controls.Add(this.dgvPrestamoVP);
            this.TPPrestamoV.Controls.Add(this.groupBox3);
            this.TPPrestamoV.Controls.Add(this.groupBox4);
            this.TPPrestamoV.Location = new System.Drawing.Point(4, 22);
            this.TPPrestamoV.Name = "TPPrestamoV";
            this.TPPrestamoV.Padding = new System.Windows.Forms.Padding(3);
            this.TPPrestamoV.Size = new System.Drawing.Size(788, 423);
            this.TPPrestamoV.TabIndex = 1;
            this.TPPrestamoV.Text = "Prestamo Videos";
            this.TPPrestamoV.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Escoger fecha de devolucion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Prestamos activos del profesor seleccionado:";
            // 
            // BtnBuscarMV
            // 
            this.BtnBuscarMV.Location = new System.Drawing.Point(681, 45);
            this.BtnBuscarMV.Name = "BtnBuscarMV";
            this.BtnBuscarMV.Size = new System.Drawing.Size(101, 26);
            this.BtnBuscarMV.TabIndex = 28;
            this.BtnBuscarMV.Text = "Buscar";
            this.BtnBuscarMV.UseVisualStyleBackColor = true;
            this.BtnBuscarMV.Click += new System.EventHandler(this.BtnBuscarMV_Click);
            // 
            // dgvPrestamoVM
            // 
            this.dgvPrestamoVM.AllowUserToAddRows = false;
            this.dgvPrestamoVM.AllowUserToDeleteRows = false;
            this.dgvPrestamoVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoVM.Location = new System.Drawing.Point(488, 83);
            this.dgvPrestamoVM.Name = "dgvPrestamoVM";
            this.dgvPrestamoVM.ReadOnly = true;
            this.dgvPrestamoVM.Size = new System.Drawing.Size(294, 124);
            this.dgvPrestamoVM.TabIndex = 27;
            this.dgvPrestamoVM.SelectionChanged += new System.EventHandler(this.dgvPrestamoVM_SelectionChanged);
            // 
            // dgvPrestamoVV
            // 
            this.dgvPrestamoVV.AllowUserToAddRows = false;
            this.dgvPrestamoVV.AllowUserToDeleteRows = false;
            this.dgvPrestamoVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoVV.Location = new System.Drawing.Point(6, 83);
            this.dgvPrestamoVV.Name = "dgvPrestamoVV";
            this.dgvPrestamoVV.ReadOnly = true;
            this.dgvPrestamoVV.Size = new System.Drawing.Size(439, 124);
            this.dgvPrestamoVV.TabIndex = 26;
            // 
            // BtnGuardarV
            // 
            this.BtnGuardarV.Location = new System.Drawing.Point(550, 340);
            this.BtnGuardarV.Name = "BtnGuardarV";
            this.BtnGuardarV.Size = new System.Drawing.Size(200, 47);
            this.BtnGuardarV.TabIndex = 25;
            this.BtnGuardarV.Text = "Registrar Prestamo";
            this.BtnGuardarV.UseVisualStyleBackColor = true;
            this.BtnGuardarV.Click += new System.EventHandler(this.BtnGuardarV_Click);
            // 
            // dtpVideo
            // 
            this.dtpVideo.Location = new System.Drawing.Point(550, 281);
            this.dtpVideo.Name = "dtpVideo";
            this.dtpVideo.Size = new System.Drawing.Size(200, 20);
            this.dtpVideo.TabIndex = 24;
            // 
            // dgvPrestamoVP
            // 
            this.dgvPrestamoVP.AllowUserToAddRows = false;
            this.dgvPrestamoVP.AllowUserToDeleteRows = false;
            this.dgvPrestamoVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoVP.Location = new System.Drawing.Point(6, 247);
            this.dgvPrestamoVP.Name = "dgvPrestamoVP";
            this.dgvPrestamoVP.ReadOnly = true;
            this.dgvPrestamoVP.Size = new System.Drawing.Size(506, 168);
            this.dgvPrestamoVP.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtMaestroV);
            this.groupBox3.Location = new System.Drawing.Point(474, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 215);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de Maestro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre o Apellido:";
            // 
            // TxtMaestroV
            // 
            this.TxtMaestroV.Location = new System.Drawing.Point(14, 42);
            this.TxtMaestroV.Name = "TxtMaestroV";
            this.TxtMaestroV.Size = new System.Drawing.Size(175, 20);
            this.TxtMaestroV.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cmbVideo);
            this.groupBox4.Controls.Add(this.BtnBuscarV);
            this.groupBox4.Controls.Add(this.TxtFraseV);
            this.groupBox4.Location = new System.Drawing.Point(-2, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 215);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda de Video";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Criterio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Frase o palabra de busqueda:";
            // 
            // cmbVideo
            // 
            this.cmbVideo.FormattingEnabled = true;
            this.cmbVideo.Items.AddRange(new object[] {
            "Titulo",
            "Director(es)",
            "Productora"});
            this.cmbVideo.Location = new System.Drawing.Point(236, 43);
            this.cmbVideo.Name = "cmbVideo";
            this.cmbVideo.Size = new System.Drawing.Size(121, 21);
            this.cmbVideo.TabIndex = 12;
            // 
            // BtnBuscarV
            // 
            this.BtnBuscarV.Location = new System.Drawing.Point(363, 42);
            this.BtnBuscarV.Name = "BtnBuscarV";
            this.BtnBuscarV.Size = new System.Drawing.Size(101, 26);
            this.BtnBuscarV.TabIndex = 7;
            this.BtnBuscarV.Text = "Buscar";
            this.BtnBuscarV.UseVisualStyleBackColor = true;
            this.BtnBuscarV.Click += new System.EventHandler(this.BtnBuscarV_Click);
            // 
            // TxtFraseV
            // 
            this.TxtFraseV.Location = new System.Drawing.Point(8, 42);
            this.TxtFraseV.Name = "TxtFraseV";
            this.TxtFraseV.Size = new System.Drawing.Size(222, 20);
            this.TxtFraseV.TabIndex = 11;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrestamo_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.tabControl1.ResumeLayout(false);
            this.TPPrestamoL.ResumeLayout(false);
            this.TPPrestamoL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TPPrestamoV.ResumeLayout(false);
            this.TPPrestamoV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoVP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPPrestamoL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscarML;
        private System.Windows.Forms.DataGridView dgvPrestamoLM;
        private System.Windows.Forms.DataGridView dgvPrestamoLL;
        private System.Windows.Forms.Button BtnGuardarL;
        private System.Windows.Forms.DateTimePicker dtpLibro;
        private System.Windows.Forms.DataGridView dgvPrestamoLP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMaestroL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Button BtnBuscarL;
        private System.Windows.Forms.TextBox TxtFraseL;
        private System.Windows.Forms.TabPage TPPrestamoV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBuscarMV;
        private System.Windows.Forms.DataGridView dgvPrestamoVM;
        private System.Windows.Forms.DataGridView dgvPrestamoVV;
        private System.Windows.Forms.Button BtnGuardarV;
        private System.Windows.Forms.DateTimePicker dtpVideo;
        private System.Windows.Forms.DataGridView dgvPrestamoVP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMaestroV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVideo;
        private System.Windows.Forms.Button BtnBuscarV;
        private System.Windows.Forms.TextBox TxtFraseV;
    }
}