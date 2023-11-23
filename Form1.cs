using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaHelper
{
    public partial class frmPaineis : Form
    {
        public frmPaineis()
        {
            InitializeComponent();
        }

        private void btnMudaAmarelo_Click(object sender, EventArgs e)
        {
            pnlEsquerdo.BackColor = Color.Yellow;
            pnlDireito.BackColor = Color.Yellow;
            btnMudaAzul.BackColor = Color.Yellow;
        }

        private void btnMudaAzul_Click(object sender, EventArgs e)
        {
            pnlDireito.BackColor = Color.Blue;
            pnlEsquerdo.BackColor = Color.Blue;
            btnMudaAmarelo.BackColor = Color.Blue;
        }
    }
}
