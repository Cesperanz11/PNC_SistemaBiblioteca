
namespace Sistema.Presentacion.Reportes
{
    partial class FrmPrestamosLibros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.prestamoslibros_reportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSistema = new Sistema.Presentacion.Reportes.DsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prestamoslibros_reportesTableAdapter = new Sistema.Presentacion.Reportes.DsSistemaTableAdapters.prestamoslibros_reportesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoslibros_reportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamoslibros_reportesBindingSource
            // 
            this.prestamoslibros_reportesBindingSource.DataMember = "prestamoslibros_reportes";
            this.prestamoslibros_reportesBindingSource.DataSource = this.DsSistema;
            // 
            // DsSistema
            // 
            this.DsSistema.DataSetName = "DsSistema";
            this.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsPrestamosLibros";
            reportDataSource1.Value = this.prestamoslibros_reportesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptPrestamosLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // prestamoslibros_reportesTableAdapter
            // 
            this.prestamoslibros_reportesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrestamosLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrestamosLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos de Libros";
            this.Load += new System.EventHandler(this.FrmPrestamosLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoslibros_reportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prestamoslibros_reportesBindingSource;
        private DsSistema DsSistema;
        private DsSistemaTableAdapters.prestamoslibros_reportesTableAdapter prestamoslibros_reportesTableAdapter;
    }
}