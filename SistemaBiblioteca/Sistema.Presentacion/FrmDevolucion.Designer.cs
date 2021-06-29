
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
            this.TPDevolucionL = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarL = new System.Windows.Forms.Button();
            this.dgvDevolucionLP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDevolucionLM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscarL = new System.Windows.Forms.Button();
            this.TxtFraseL = new System.Windows.Forms.TextBox();
            this.TPDevolucionV = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDevolucionVM = new System.Windows.Forms.DataGridView();
            this.BtnGuardarV = new System.Windows.Forms.Button();
            this.dgvDevolucionVP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBuscarV = new System.Windows.Forms.Button();
            this.TxtFraseV = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TPDevolucionL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionLP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionLM)).BeginInit();
            this.TPDevolucionV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionVP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPDevolucionL);
            this.tabControl1.Controls.Add(this.TPDevolucionV);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // TPDevolucionL
            // 
            this.TPDevolucionL.Controls.Add(this.label1);
            this.TPDevolucionL.Controls.Add(this.BtnGuardarL);
            this.TPDevolucionL.Controls.Add(this.dgvDevolucionLP);
            this.TPDevolucionL.Controls.Add(this.groupBox2);
            this.TPDevolucionL.Location = new System.Drawing.Point(4, 22);
            this.TPDevolucionL.Name = "TPDevolucionL";
            this.TPDevolucionL.Padding = new System.Windows.Forms.Padding(3);
            this.TPDevolucionL.Size = new System.Drawing.Size(790, 426);
            this.TPDevolucionL.TabIndex = 0;
            this.TPDevolucionL.Text = "Devolucion Libros";
            this.TPDevolucionL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Prestamos activos del profesor seleccionado:";
            // 
            // BtnGuardarL
            // 
            this.BtnGuardarL.Location = new System.Drawing.Point(557, 159);
            this.BtnGuardarL.Name = "BtnGuardarL";
            this.BtnGuardarL.Size = new System.Drawing.Size(200, 47);
            this.BtnGuardarL.TabIndex = 25;
            this.BtnGuardarL.Text = "Devolucion de Libro";
            this.BtnGuardarL.UseVisualStyleBackColor = true;
            this.BtnGuardarL.Click += new System.EventHandler(this.BtnGuardarL_Click);
            // 
            // dgvDevolucionLP
            // 
            this.dgvDevolucionLP.AllowUserToAddRows = false;
            this.dgvDevolucionLP.AllowUserToDeleteRows = false;
            this.dgvDevolucionLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucionLP.Location = new System.Drawing.Point(31, 249);
            this.dgvDevolucionLP.Name = "dgvDevolucionLP";
            this.dgvDevolucionLP.ReadOnly = true;
            this.dgvDevolucionLP.Size = new System.Drawing.Size(559, 168);
            this.dgvDevolucionLP.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dgvDevolucionLM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnBuscarL);
            this.groupBox2.Controls.Add(this.TxtFraseL);
            this.groupBox2.Location = new System.Drawing.Point(31, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 215);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de Maestro";
            // 
            // dgvDevolucionLM
            // 
            this.dgvDevolucionLM.AllowUserToAddRows = false;
            this.dgvDevolucionLM.AllowUserToDeleteRows = false;
            this.dgvDevolucionLM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucionLM.Location = new System.Drawing.Point(8, 74);
            this.dgvDevolucionLM.Name = "dgvDevolucionLM";
            this.dgvDevolucionLM.ReadOnly = true;
            this.dgvDevolucionLM.Size = new System.Drawing.Size(439, 124);
            this.dgvDevolucionLM.TabIndex = 26;
            this.dgvDevolucionLM.SelectionChanged += new System.EventHandler(this.dgvDevolucionLM_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre o apellido a buscar:";
            // 
            // BtnBuscarL
            // 
            this.BtnBuscarL.Location = new System.Drawing.Point(323, 42);
            this.BtnBuscarL.Name = "BtnBuscarL";
            this.BtnBuscarL.Size = new System.Drawing.Size(141, 26);
            this.BtnBuscarL.TabIndex = 7;
            this.BtnBuscarL.Text = "Buscar";
            this.BtnBuscarL.UseVisualStyleBackColor = true;
            this.BtnBuscarL.Click += new System.EventHandler(this.BtnBuscarL_Click);
            // 
            // TxtFraseL
            // 
            this.TxtFraseL.Location = new System.Drawing.Point(8, 42);
            this.TxtFraseL.Name = "TxtFraseL";
            this.TxtFraseL.Size = new System.Drawing.Size(309, 20);
            this.TxtFraseL.TabIndex = 11;
            // 
            // TPDevolucionV
            // 
            this.TPDevolucionV.Controls.Add(this.label3);
            this.TPDevolucionV.Controls.Add(this.dgvDevolucionVM);
            this.TPDevolucionV.Controls.Add(this.BtnGuardarV);
            this.TPDevolucionV.Controls.Add(this.dgvDevolucionVP);
            this.TPDevolucionV.Controls.Add(this.groupBox1);
            this.TPDevolucionV.Location = new System.Drawing.Point(4, 22);
            this.TPDevolucionV.Name = "TPDevolucionV";
            this.TPDevolucionV.Padding = new System.Windows.Forms.Padding(3);
            this.TPDevolucionV.Size = new System.Drawing.Size(790, 426);
            this.TPDevolucionV.TabIndex = 1;
            this.TPDevolucionV.Text = "Devolucion Videos";
            this.TPDevolucionV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Prestamos activos del profesor seleccionado:";
            // 
            // dgvDevolucionVM
            // 
            this.dgvDevolucionVM.AllowUserToAddRows = false;
            this.dgvDevolucionVM.AllowUserToDeleteRows = false;
            this.dgvDevolucionVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucionVM.Location = new System.Drawing.Point(35, 88);
            this.dgvDevolucionVM.Name = "dgvDevolucionVM";
            this.dgvDevolucionVM.ReadOnly = true;
            this.dgvDevolucionVM.Size = new System.Drawing.Size(439, 124);
            this.dgvDevolucionVM.TabIndex = 33;
            // 
            // BtnGuardarV
            // 
            this.BtnGuardarV.Location = new System.Drawing.Point(549, 165);
            this.BtnGuardarV.Name = "BtnGuardarV";
            this.BtnGuardarV.Size = new System.Drawing.Size(200, 47);
            this.BtnGuardarV.TabIndex = 32;
            this.BtnGuardarV.Text = "Devolucion de Video";
            this.BtnGuardarV.UseVisualStyleBackColor = true;
            // 
            // dgvDevolucionVP
            // 
            this.dgvDevolucionVP.AllowUserToAddRows = false;
            this.dgvDevolucionVP.AllowUserToDeleteRows = false;
            this.dgvDevolucionVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucionVP.Location = new System.Drawing.Point(30, 249);
            this.dgvDevolucionVP.Name = "dgvDevolucionVP";
            this.dgvDevolucionVP.ReadOnly = true;
            this.dgvDevolucionVP.Size = new System.Drawing.Size(559, 168);
            this.dgvDevolucionVP.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnBuscarV);
            this.groupBox1.Controls.Add(this.TxtFraseV);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 215);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Maestro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre o apellido a buscar:";
            // 
            // BtnBuscarV
            // 
            this.BtnBuscarV.Location = new System.Drawing.Point(321, 42);
            this.BtnBuscarV.Name = "BtnBuscarV";
            this.BtnBuscarV.Size = new System.Drawing.Size(143, 26);
            this.BtnBuscarV.TabIndex = 7;
            this.BtnBuscarV.Text = "Buscar";
            this.BtnBuscarV.UseVisualStyleBackColor = true;
            // 
            // TxtFraseV
            // 
            this.TxtFraseV.Location = new System.Drawing.Point(8, 42);
            this.TxtFraseV.Name = "TxtFraseV";
            this.TxtFraseV.Size = new System.Drawing.Size(307, 20);
            this.TxtFraseV.TabIndex = 11;
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDevolucion";
            this.Text = "FrmDevolucion";
            this.Load += new System.EventHandler(this.FrmDevolucion_Load);
            this.tabControl1.ResumeLayout(false);
            this.TPDevolucionL.ResumeLayout(false);
            this.TPDevolucionL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionLP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionLM)).EndInit();
            this.TPDevolucionV.ResumeLayout(false);
            this.TPDevolucionV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionVP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPDevolucionL;
        private System.Windows.Forms.TabPage TPDevolucionV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDevolucionLM;
        private System.Windows.Forms.Button BtnGuardarL;
        private System.Windows.Forms.DataGridView dgvDevolucionLP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscarL;
        private System.Windows.Forms.TextBox TxtFraseL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDevolucionVM;
        private System.Windows.Forms.Button BtnGuardarV;
        private System.Windows.Forms.DataGridView dgvDevolucionVP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBuscarV;
        private System.Windows.Forms.TextBox TxtFraseV;
    }
}