
namespace Sistema.Presentacion
{
    partial class FrmMaestros
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
            this.TabControlMaestros = new System.Windows.Forms.TabControl();
            this.TPLibros = new System.Windows.Forms.TabPage();
            this.TPVideos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarL = new System.Windows.Forms.Button();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.TxtSearchL = new System.Windows.Forms.TextBox();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.TabControlMaestros.SuspendLayout();
            this.TPLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMaestros
            // 
            this.TabControlMaestros.Controls.Add(this.TPLibros);
            this.TabControlMaestros.Controls.Add(this.TPVideos);
            this.TabControlMaestros.Location = new System.Drawing.Point(-1, 40);
            this.TabControlMaestros.Name = "TabControlMaestros";
            this.TabControlMaestros.SelectedIndex = 0;
            this.TabControlMaestros.Size = new System.Drawing.Size(802, 413);
            this.TabControlMaestros.TabIndex = 0;
            // 
            // TPLibros
            // 
            this.TPLibros.Controls.Add(this.dgvLibros);
            this.TPLibros.Controls.Add(this.LblCriterio);
            this.TPLibros.Controls.Add(this.TxtSearchL);
            this.TPLibros.Controls.Add(this.cmbLibros);
            this.TPLibros.Controls.Add(this.BtnBuscarL);
            this.TPLibros.Location = new System.Drawing.Point(4, 22);
            this.TPLibros.Name = "TPLibros";
            this.TPLibros.Padding = new System.Windows.Forms.Padding(3);
            this.TPLibros.Size = new System.Drawing.Size(794, 387);
            this.TPLibros.TabIndex = 0;
            this.TPLibros.Text = "Libros";
            this.TPLibros.UseVisualStyleBackColor = true;
            // 
            // TPVideos
            // 
            this.TPVideos.Location = new System.Drawing.Point(4, 22);
            this.TPVideos.Name = "TPVideos";
            this.TPVideos.Padding = new System.Windows.Forms.Padding(3);
            this.TPVideos.Size = new System.Drawing.Size(794, 387);
            this.TPVideos.TabIndex = 1;
            this.TPVideos.Text = "Videos";
            this.TPVideos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE CONSULTA DE CONTENIDOS DE BIBLIOTECA CENTRAL";
            // 
            // BtnBuscarL
            // 
            this.BtnBuscarL.Location = new System.Drawing.Point(662, 21);
            this.BtnBuscarL.Name = "BtnBuscarL";
            this.BtnBuscarL.Size = new System.Drawing.Size(87, 23);
            this.BtnBuscarL.TabIndex = 0;
            this.BtnBuscarL.Text = "Buscar";
            this.BtnBuscarL.UseVisualStyleBackColor = true;
            this.BtnBuscarL.Click += new System.EventHandler(this.BtnBuscarL_Click);
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Items.AddRange(new object[] {
            "ISBN",
            "Titulo",
            "Autor"});
            this.cmbLibros.Location = new System.Drawing.Point(535, 23);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(121, 21);
            this.cmbLibros.TabIndex = 2;
            // 
            // TxtSearchL
            // 
            this.TxtSearchL.Location = new System.Drawing.Point(19, 23);
            this.TxtSearchL.Name = "TxtSearchL";
            this.TxtSearchL.Size = new System.Drawing.Size(379, 20);
            this.TxtSearchL.TabIndex = 3;
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Location = new System.Drawing.Point(421, 26);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(108, 13);
            this.LblCriterio.TabIndex = 4;
            this.LblCriterio.Text = "Criterio de Busqueda:";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(0, 63);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.Size = new System.Drawing.Size(794, 324);
            this.dgvLibros.TabIndex = 5;
            // 
            // FrmMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabControlMaestros);
            this.Name = "FrmMaestros";
            this.Text = "Sistema de Biblioteca (Maestros)";
            this.Load += new System.EventHandler(this.FrmMaestros_Load);
            this.TabControlMaestros.ResumeLayout(false);
            this.TPLibros.ResumeLayout(false);
            this.TPLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMaestros;
        private System.Windows.Forms.TabPage TPLibros;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.TextBox TxtSearchL;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Button BtnBuscarL;
        private System.Windows.Forms.TabPage TPVideos;
        private System.Windows.Forms.Label label1;
    }
}