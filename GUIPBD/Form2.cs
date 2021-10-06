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
    public partial class Form2 : Form
    {
        string mode = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.cargaDatos();
        }

        private void cargaDatos()
        {
            try
            {
                this.empresaTableAdapter.Fill(this.pBDDataSet.Empresa);
                this.modoEdicion("read");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de datos: " + ex.Message.ToString());
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pBDDataSet);

        }
        private void modoEdicion(string mode)
        {

            this.mode = mode;

            switch (mode)
            {
                case "read":
                    this.pnlTop.Enabled = true;
                    this.pnlButtom.Enabled = false;
                    this.empresaDataGridView.Enabled = true;
                    this.empresaBindingNavigator.Enabled = true;
                    break;

                case "insert":
                    this.pnlTop.Enabled = false;
                    this.pnlButtom.Enabled = true;
                    this.empresaDataGridView.Enabled = false;
                    this.empresaBindingNavigator.Enabled = false;
                    break;

                case "update":
                    this.pnlTop.Enabled = false;
                    this.pnlButtom.Enabled = true;
                    this.empresaDataGridView.Enabled = false;
                    this.empresaBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.modoEdicion("insert");
            this.idEmpresaTextBox.Text = "";
            this.razonSocialTextBox.Text = "";
            this.razonSocialTextBox.Focus();
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
                    int id = int.Parse(this.idEmpresaTextBox.Text);
                    this.empresaTableAdapter.Delete(id);
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

            if (this.razonSocialTextBox.Text.Trim() == "")
            {
                validar = false;
                this.errorProvider1.SetError(this.razonSocialTextBox, "Campo rquerido");
            }
            return validar;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validar()) {
                    switch (this.mode) {
                        case "insert":
                            this.empresaTableAdapter.Insert(this.razonSocialTextBox.Text);
                            break;
                        case "update":
                            int id = int.Parse(this.idEmpresaTextBox.Text);
                            this.empresaTableAdapter.Update(this.razonSocialTextBox.Text, id);
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
