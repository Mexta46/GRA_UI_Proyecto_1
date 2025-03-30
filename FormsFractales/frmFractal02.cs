using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsFractales
{
    public partial class frmFractal02 : Form
    {
        public frmFractal02()
        {
            InitializeComponent();
        }

        private void frmFractal02_Load(object sender, EventArgs e)
        {
            MandelbrodSet();
        }

        private void MandelbrodSet()
        {
            int width = ptbMandelbrot.Width;
            int height = ptbMandelbrot.Height;

            Bitmap bmp = new Bitmap(width, height);

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    int x = col;
                    int y = row;

                    bool isSierpinski = true;
                    while (x > 0 || y > 0)
                    {
                        if ((x % 2 == 1) && (y % 2 == 1))
                        {
                            isSierpinski = false;
                            break;
                        }
                        x /= 2;
                        y /= 2;
                    }

                    if (isSierpinski)
                    {
                        bmp.SetPixel(col, row, Color.White);
                    }
                    else
                    {
                        bmp.SetPixel(col, row, Color.Black);
                    }
                }
            }

            ptbMandelbrot.Image = bmp;


        }
    }
}
