
namespace GUIPBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnAlumnoEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.Image")));
            this.btnEmpresa.Location = new System.Drawing.Point(134, 162);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(133, 91);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenidos al sistema de control de alumnos y empresas";
            // 
            // btnAlumno
            // 
            this.btnAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumno.Image")));
            this.btnAlumno.Location = new System.Drawing.Point(378, 162);
            this.btnAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(133, 91);
            this.btnAlumno.TabIndex = 2;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlumno.UseVisualStyleBackColor = true;
            // 
            // btnAlumnoEmpresa
            // 
            this.btnAlumnoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnoEmpresa.Image")));
            this.btnAlumnoEmpresa.Location = new System.Drawing.Point(616, 162);
            this.btnAlumnoEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlumnoEmpresa.Name = "btnAlumnoEmpresa";
            this.btnAlumnoEmpresa.Size = new System.Drawing.Size(133, 91);
            this.btnAlumnoEmpresa.TabIndex = 3;
            this.btnAlumnoEmpresa.Text = "AlumnoEmpresa";
            this.btnAlumnoEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlumnoEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlumnoEmpresa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 388);
            this.Controls.Add(this.btnAlumnoEmpresa);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema PBD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnAlumnoEmpresa;
    }
}

