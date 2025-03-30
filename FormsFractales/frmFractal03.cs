using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsFractales
{
    public partial class frmFractal03 : Form
    {
        public frmFractal03()
        {
            InitializeComponent();
        }

        private void frmFractal03_Load(object sender, EventArgs e)
        {
            DrawMandelbrot();
        }

        private void DrawMandelbrot()
        {
            int width = ptbMandelbrot.Width;
            int height = ptbMandelbrot.Height;
            Bitmap bmp = new Bitmap(width, height);
            int maxIterations = 1000;
            double moveX = -0.7, moveY = 0;
            double aspectRatio = (double)width / height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double zx = 0, zy = 0;
                    double cX = (x - width / 2.0) * (4.0 / width) * aspectRatio + moveX;
                    double cY = (y - height / 2.0) * (4.0 / height) + moveY;
                    int iteration = 0;
                    while (zx * zx + zy * zy < 4 && iteration < maxIterations)
                    {
                        double r = Math.Sqrt(zx * zx + zy * zy);
                        double theta = Math.Atan2(zy, zx);
                        double temp = Math.Pow(r, 7) * Math.Cos(7 * theta) + cX;
                        zy = Math.Pow(r, 7) * Math.Sin(7 * theta) + cY;
                        zx = temp;
                        iteration++;
                    }
                    int colorValue = iteration % 256;
                    bmp.SetPixel(x, y, Color.FromArgb(colorValue / 3, colorValue / 2, colorValue));
                }
            }
            ptbMandelbrot.Image = bmp;
        }
    }
}