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
    public partial class fAlumno : Form
    {
        string mode = "";

        public fAlumno()
        {
            InitializeComponent();
        }

        private void alumnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pBDDataSet);

        }

        private void fAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            this.cargaDatos();

        }

        private void cargaDatos()
        {
            try
            {
                this.alumnoTableAdapter.Fill(this.pBDDataSet.Alumno);
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
                    this.alumnoDataGridView.Enabled = true;
                    this.alumnoBindingNavigator.Enabled = true;
                    break;

                case "insert":
                    this.pnlTop.Enabled = false;
                    this.pnlButtom.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;

                case "update":
                    this.pnlTop.Enabled = false;
                    this.pnlButtom.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.modoEdicion("insert");
            this.idAlumnoTextBox.Text = "";
            this.nombreTextBox.Text = "";
            this.nombreTextBox.Focus();
            this.primerApellidoTextBox.Text = "";
            this.segundoApellidoTextBox.Text = "";
            this.noControlTextBox.Text = "";
            this.emailTextBox.Text = "";
            this.telefonoTextBox.Text = "";
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
                    int id = int.Parse(this.idAlumnoTextBox.Text);
                    this.alumnoTableAdapter.Delete(id);
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

        private bool validar()
        {
            this.errorProvider1.Clear();
            bool validar = true;

            if (this.nombreTextBox.Text.Trim() == "")
            {
                validar = false;
                this.errorProvider1.SetError(this.nombreTextBox, "Campo rquerido");
            }
            if (this.primerApellidoTextBox.Text.Trim() == "")
            {
                validar = false;
                this.errorProvider1.SetError(this.primerApellidoTextBox, "Campo rquerido");
            }
            if (this.segundoApellidoTextBox.Text.Trim() == "")
            {
                validar = false;
                this.errorProvider1.SetError(this.segundoApellidoTextBox, "Campo rquerido");
            }
            if (this.noControlTextBox.Text.Trim() == "")
            {
                validar = false;
                this.errorProvider1.SetError(this.noControlTextBox, "Campo rquerido");
            }
            if (this.emailTextBox.Text.Trim() == "")
            {
                validar = false;
                this.errorProvider1.SetError(this.emailTextBox, "Campo rquerido");
            }
            if (this.telefonoTextBox.Text.Trim() == "")
            {
                validar = false;
                this.errorProvider1.SetError(this.telefonoTextBox, "Campo rquerido");
            }
            return validar;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validar())
                {
                    switch (this.mode)
                    {
                        case "insert":
                            this.alumnoTableAdapter.Insert(this.nombreTextBox.Text,
                                                           this.primerApellidoTextBox.Text,
                                                           this.segundoApellidoTextBox.Text,
                                                           this.noControlTextBox.Text,
                                                           this.emailTextBox.Text,
                                                           this.telefonoTextBox.Text);
                            break;
                        case "update":
                            int id = int.Parse(this.idAlumnoTextBox.Text);
                            this.alumnoTableAdapter.Update(this.nombreTextBox.Text,
                                                           this.primerApellidoTextBox.Text,
                                                           this.segundoApellidoTextBox.Text,
                                                           this.noControlTextBox.Text,
                                                           this.emailTextBox.Text,
                                                           this.telefonoTextBox.Text, id);
                            break;
                    }
                    this.cargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }
    }
}
