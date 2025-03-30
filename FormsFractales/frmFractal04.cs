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
    public partial class frmFractal04 : Form
    {
        public frmFractal04()
        {
            InitializeComponent();
        }

        private void frmFractal04_Load(object sender, EventArgs e)
        {
            DrawMandelbrot();
        }

        private void DrawMandelbrot()
        {
            int width = ptbMandelbrot.Width;
            int height = ptbMandelbrot.Height;

            Bitmap bmp = new Bitmap(width, height);

            double c_re = -0.7, c_im = 0.27015; // Valores constantes para el fractal de Julia

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    double x = (col - width / 2.0) * 4.0 / width;
                    double y = (row - height / 2.0) * 4.0 / height;

                    int iteraciones = 0;
                    while (iteraciones < 1000 && (x * x + y * y) < 4.0)
                    {
                        double x_temp = x * x - y * y + c_re;
                        y = 2 * x * y + c_im;
                        x = x_temp;
                        iteraciones++;
                    }

                    if (iteraciones < 1000)
                    {
                        bmp.SetPixel(col, row, Color.FromArgb(iteraciones % 128, iteraciones % 40 * 5, iteraciones % 10));
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
