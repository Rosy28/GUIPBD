using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPBD
{
    public partial class fAlumnoEmpresa : Form
    {
        string mode = "";

        public fAlumnoEmpresa()
        {
            InitializeComponent();
        }

        private void fAlumnoEmpresa_Load(object sender, EventArgs e)
        {
            this.cargaDatos();
        }

        private void cargaDatos()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Empresa' Puede moverla o quitarla según sea necesario.
                this.empresaTableAdapter.Fill(this.pBDDataSet.Empresa);
                // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Alumno' Puede moverla o quitarla según sea necesario.
                this.alumnoTableAdapter.Fill(this.pBDDataSet.Alumno);
                // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.vAlumnoEmpresa' Puede moverla o quitarla según sea necesario.
                this.vAlumnoEmpresaTableAdapter.Fill(this.pBDDataSet.vAlumnoEmpresa);
                this.modoEdicion("read");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de datos: " + ex.Message.ToString());
            }
        }

        private void modoEdicion(string mode)
        {

            this.mode = mode;

            switch (mode)
            {
                case "read":
                    this.pnlTop.Enabled = true;
                    this.pnlButtom.Enabled = false;
                    this.vAlumnoEmpresaDataGridView.Enabled = true;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = true;
                    break;

                case "insert":
                    this.pnlTop.Enabled = false;
                    this.pnlButtom.Enabled = true;
                    this.vAlumnoEmpresaDataGridView.Enabled = false;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = false;
                    break;

                case "update":
                    this.pnlTop.Enabled = false;
                    this.pnlButtom.Enabled = true;
                    this.vAlumnoEmpresaDataGridView.Enabled = false;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void vAlumnoEmpresaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try 
            {
                if (this.vAlumnoEmpresaDataGridView.Rows.Count == 0)
                    return;
                //Sincronizar los combo box
                this.cboAlumno.SelectedValue = this.vAlumnoEmpresaDataGridView.CurrentRow.Cells["idAlumno"].Value.ToString();
                this.cboEmpresa.SelectedValue = this.vAlumnoEmpresaDataGridView.CurrentRow.Cells["idEmpresa"].Value.ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al sincronizar la grid: " + ex.Message.ToString());
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.modoEdicion("insert");
            this.idAlumnoEmpresaTextBox.Text = "";
            this.cboAlumno.SelectedIndex = 0;
            this.cboEmpresa.SelectedIndex = 0;
            this.anioInicioNumericUpDown.Value = 0;
            this.anioFinNumericUpDown.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cargaDatos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.modoEdicion("update");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Estas seguro de eliminar este registro", "Eliminar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(this.idAlumnoEmpresaTextBox.Text);
                    this.alumnoEmpresaTableAdapter.Delete(id);
                    this.cargaDatos();
                }
                else
                {
                    this.cargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de datos: " + ex.Message.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.mode)
                {
                     case "insert":
                        this.alumnoEmpresaTableAdapter.Insert((int)this.cboAlumno.SelectedValue, 
                                                              (int)this.cboEmpresa.SelectedValue,
                                                              (short)this.anioInicioNumericUpDown.Value,
                                                              (short)this.anioFinNumericUpDown.Value);
                     break;
                     case "update":
                        int id = int.Parse(this.idAlumnoEmpresaTextBox.Text);
                        this.alumnoEmpresaTableAdapter.Update((int)this.cboAlumno.SelectedValue,
                                                              (int)this.cboEmpresa.SelectedValue,
                                                              (short)this.anioInicioNumericUpDown.Value,
                                                              (short)this.anioFinNumericUpDown.Value, id);
                     break;
                }
                this.cargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rAlumnoEmpresa report = new rAlumnoEmpresa();
            report.ShowDialog();
        }
    }
}
