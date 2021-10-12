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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Form2 empresa = new Form2();
            empresa.ShowDialog();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            fAlumno alumno = new fAlumno();
            alumno.ShowDialog();
        }
    }
}
