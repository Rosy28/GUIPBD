
namespace GUIPBD
{
    partial class rAlumnoEmpresa
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PBDDataSet = new GUIPBD.PBDDataSet();
            this.vAlumnoEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vAlumnoEmpresaTableAdapter = new GUIPBD.PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDatos";
            reportDataSource1.Value = this.vAlumnoEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUIPBD.rptAlumnoEmpresa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PBDDataSet
            // 
            this.PBDDataSet.DataSetName = "PBDDataSet";
            this.PBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vAlumnoEmpresaBindingSource
            // 
            this.vAlumnoEmpresaBindingSource.DataMember = "vAlumnoEmpresa";
            this.vAlumnoEmpresaBindingSource.DataSource = this.PBDDataSet;
            // 
            // vAlumnoEmpresaTableAdapter
            // 
            this.vAlumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // rAlumnoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rAlumnoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Alumnos-Empresas";
            this.Load += new System.EventHandler(this.rAlumnoEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vAlumnoEmpresaBindingSource;
        private PBDDataSet PBDDataSet;
        private PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter vAlumnoEmpresaTableAdapter;
    }
}