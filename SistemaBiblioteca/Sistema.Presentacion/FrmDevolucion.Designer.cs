
namespace Sistema.Presentacion
{
    partial class FrmDevolucion
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrestamoLL = new System.Windows.Forms.DataGridView();
            this.BtnGuardarL = new System.Windows.Forms.Button();
            this.dtpLibro = new System.Windows.Forms.DateTimePicker();
            this.dgvPrestamoLP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.BtnBuscarL = new System.Windows.Forms.Button();
            this.TxtFraseL = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvPrestamoLL);
            this.tabPage1.Controls.Add(this.BtnGuardarL);
            this.tabPage1.Controls.Add(this.dtpLibro);
            this.tabPage1.Controls.Add(this.dgvPrestamoLP);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Escoger fecha de devolucion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Prestamos activos del profesor seleccionado:";
            // 
            // dgvPrestamoLL
            // 
            this.dgvPrestamoLL.AllowUserToAddRows = false;
            this.dgvPrestamoLL.AllowUserToDeleteRows = false;
            this.dgvPrestamoLL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoLL.Location = new System.Drawing.Point(7, 85);
            this.dgvPrestamoLL.Name = "dgvPrestamoLL";
            this.dgvPrestamoLL.ReadOnly = true;
            this.dgvPrestamoLL.Size = new System.Drawing.Size(439, 124);
            this.dgvPrestamoLL.TabIndex = 26;
            // 
            // BtnGuardarL
            // 
            this.BtnGuardarL.Location = new System.Drawing.Point(551, 342);
            this.BtnGuardarL.Name = "BtnGuardarL";
            this.BtnGuardarL.Size = new System.Drawing.Size(200, 47);
            this.BtnGuardarL.TabIndex = 25;
            this.BtnGuardarL.Text = "Registrar Prestamo";
            this.BtnGuardarL.UseVisualStyleBackColor = true;
            // 
            // dtpLibro
            // 
            this.dtpLibro.Location = new System.Drawing.Point(551, 283);
            this.dtpLibro.Name = "dtpLibro";
            this.dtpLibro.Size = new System.Drawing.Size(200, 20);
            this.dtpLibro.TabIndex = 24;
            // 
            // dgvPrestamoLP
            // 
            this.dgvPrestamoLP.AllowUserToAddRows = false;
            this.dgvPrestamoLP.AllowUserToDeleteRows = false;
            this.dgvPrestamoLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoLP.Location = new System.Drawing.Point(7, 249);
            this.dgvPrestamoLP.Name = "dgvPrestamoLP";
            this.dgvPrestamoLP.ReadOnly = true;
            this.dgvPrestamoLP.Size = new System.Drawing.Size(506, 168);
            this.dgvPrestamoLP.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbLibro);
            this.groupBox2.Controls.Add(this.BtnBuscarL);
            this.groupBox2.Controls.Add(this.TxtFraseL);
            this.groupBox2.Location = new System.Drawing.Point(-1, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 215);
            this.groupBox2.TabIndex = 29;
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
            // 
            // TxtFraseL
            // 
            this.TxtFraseL.Location = new System.Drawing.Point(8, 42);
            this.TxtFraseL.Name = "TxtFraseL";
            this.TxtFraseL.Size = new System.Drawing.Size(222, 20);
            this.TxtFraseL.TabIndex = 11;
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDevolucion";
            this.Text = "FrmDevolucion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrestamoLL;
        private System.Windows.Forms.Button BtnGuardarL;
        private System.Windows.Forms.DateTimePicker dtpLibro;
        private System.Windows.Forms.DataGridView dgvPrestamoLP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Button BtnBuscarL;
        private System.Windows.Forms.TextBox TxtFraseL;
    }
}