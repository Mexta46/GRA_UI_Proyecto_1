using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;


namespace FormsFractales
{
    public partial class frmDibujoMovil : Form
    {
        Timer timer = new Timer();
        int y = 0;
        int dy = 5;
        int ballWidth = 50;
        int ballHeight = 50;
        bool isSquashing = false;
        int squashTimer = 0;

        public frmDibujoMovil()
        {
            InitializeComponent();
        }

        private void frmFractal01_Load(object sender, EventArgs e)
        {
            Animacion();
        }

        private void Animacion()
        {

            PictureBox canvas = ptbMandelbrot;
            this.Controls.Add(canvas);

            timer.Interval = 30;
            timer.Tick += (s, e) =>
            {
                using (Graphics g = canvas.CreateGraphics())
                {
                    g.Clear(Color.White);

                    int groundY = canvas.Height - 50;
                    Pen suelo = new Pen(Color.Black, 2);
                    g.DrawLine(suelo, 0, groundY, canvas.Width, groundY);

                    if (!isSquashing)
                    {
                        y += dy;
                        if (y + ballHeight >= groundY)
                        {
                            y = groundY - ballHeight;
                            isSquashing = true;
                            squashTimer = 0;
                        }
                    }
                    else
                    {
                        squashTimer++;
                        if (squashTimer < 5)
                        {
                            ballHeight = 30;
                            ballWidth = 70;
                        }
                        else if (squashTimer < 10)
                        {
                            ballHeight = 40;
                            ballWidth = 60;
                        }
                        else
                        {
                            ballHeight = 50;
                            ballWidth = 50;
                            isSquashing = false;
                            dy = -dy;
                        }
                    }

                    if (!isSquashing && dy < 0)
                    {
                        y += dy;
                        dy += 1;

                        if (dy == 0)
                            dy = 5;
                    }

                    Brush brush = Brushes.OrangeRed;
                    g.FillEllipse(brush, (canvas.Width - ballWidth) / 2, y, ballWidth, ballHeight);
                }
            };

            timer.Start();
        }

    }
}
