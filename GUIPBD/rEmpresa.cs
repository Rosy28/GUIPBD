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
    public partial class rEmpresa : Form
    {
        public rEmpresa()
        {
            InitializeComponent();
        }

        private void rEmpresa_Load(object sender, EventArgs e)
        {
            this.EmpresaTableAdapter.Fill(this.PBDDataSet.Empresa);
            this.reportViewer1.RefreshReport();
        }
    }
}
