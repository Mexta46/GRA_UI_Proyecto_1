namespace FormsFractales
{
    public partial class frmFractal01 : Form
    {
        public frmFractal01()
        {
            InitializeComponent();
        }

        private void frmFractal01_Load(object sender, EventArgs e)
        {
            MandelbrodSet();
        }

        private void MandelbrodSet()
        {
            int widht = ptbMandelbrot.Width;
            int height = ptbMandelbrot.Height;

            Bitmap bmp = new Bitmap(widht, height);
            for (int row = 0; row < height; row++) {
                for (int col = 0; col < widht; col++) {
                    double c_re = (col - widht / 2.0) * 4.0 / widht;
                    double c_im = (row - height / 2.0) * 4.0 / height;

                    int iteraciones = 0;
                    double x = 0, y = 0;

                    while(iteraciones < 1000 && ((x * x) + (y * y)) < 4.0)
                    {
                        double x_temporal = (x * x) - (y * y) + c_re;
                        y = 2 * x * y + c_im;
                        x = x_temporal;
                        iteraciones++;
                    }

                    if (iteraciones < 1000)
                    {
                        //bmp.SetPixel(col, row, Color.White);
                        bmp.SetPixel(col, row, Color.FromArgb(iteraciones%128, iteraciones%40*5, iteraciones%10));
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
