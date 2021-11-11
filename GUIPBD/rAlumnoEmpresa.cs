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
    public partial class rAlumnoEmpresa : Form
    {
        public rAlumnoEmpresa()
        {
            InitializeComponent();
        }

        private void rAlumnoEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PBDDataSet.vAlumnoEmpresa' Puede moverla o quitarla según sea necesario.
            this.vAlumnoEmpresaTableAdapter.Fill(this.PBDDataSet.vAlumnoEmpresa);

            this.reportViewer1.RefreshReport();
        }
    }
}
