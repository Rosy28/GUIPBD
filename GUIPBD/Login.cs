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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conectar a la base de datos por medio del procedimiento validar que el usuario existe.
            //Validar si los campos están llenos
            if (this.Valida())
            {
                //Mandar a llamar el procedimiento de usuario a ver si existe
                this.usuarioTableAdapter.Fill(this.pbdDataSet.Usuario, this.txtUsuario.Text.Trim(), this.txtPassword.Text.Trim());
                //Si existe el usuario
                if (this.pbdDataSet.Usuario.Rows.Count > 0)
                {
                    //Existe el usuario ingresamos al menú principal
                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    //Mensaje de que el usuario o la contraseña son incorrectos
                    MessageBox.Show("El usuario o la contraseña son incorrectos", "Valida usuario",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool resultado = true;

            //validar el campo de usuario
            if (this.txtUsuario.Text.Trim() == "")
            {
                resultado = false;
                this.errorProvider1.SetError(this.txtUsuario, "Este campo es requerido");
            }
            //validar el campo de password
            if (this.txtPassword.Text.Trim() == "")
            {
                resultado = false;
                this.errorProvider1.SetError(this.txtPassword, "Este campo es requerido");
            }

            return resultado;
        }
    }
}
