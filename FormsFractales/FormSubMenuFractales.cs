using FormsFractales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class FormSubMenuFractales : Form
    {
        public FormSubMenuFractales()
        {
            InitializeComponent();
        }

        private void btnFractal1_Click(object sender, EventArgs e)
        {
            frmFractal01 frmFractal01 = new frmFractal01();
            frmFractal01.Show();
        }

        private void btnFractal2_Click(object sender, EventArgs e)
        {
            frmFractal02 frmFractal02 = new frmFractal02();
            frmFractal02.Show();
        }

        private void btnFractal3_Click(object sender, EventArgs e)
        {
            frmFractal03 frmFractal03 = new frmFractal03();
            frmFractal03.Show();
        }

        private void btnFractal4_Click(object sender, EventArgs e)
        {
            frmFractal04 frmFractal04 = new frmFractal04();
            frmFractal04.Show();
        }
    }
}
