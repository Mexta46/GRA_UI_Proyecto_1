using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsFractales;
using FormsGraficos;

namespace MenuPrincipal
{
    public partial class FormsMenu : Form
    {
        public FormsMenu()
        {
            InitializeComponent();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaConsola = @"Menu_1.exe";
                Process.Start(rutaConsola);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la consola: " + ex.Message);
            }
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaConsola = @"Menu_2.exe";
                Process.Start(rutaConsola);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la consola: " + ex.Message);
            }
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            FormSubMenuFractales frmFractales = new FormSubMenuFractales();
            frmFractales.Show();
            this.Hide();
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
