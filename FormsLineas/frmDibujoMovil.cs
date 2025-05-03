using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FormsFractales
{
    public partial class frmDibujoMovil : Form
    {
        private const float metrosPorPixel = 0.02f;
        private const float pixelPorMetro = 1 / metrosPorPixel;

        private float ballX = 50;
        private float ballY = 0;
        private float groundLevel;

        private float velocityY = 0;
        private float gravity = 0.5f;
        private float bounceFactor = 0.7f;

        private float deformation = 0f;
        private float scaleX = 1f;
        private float scaleY = 1f;

        private float deslizarVelocidad = 2f;
        private float friccion = 0.05f;

        private int radius = 30;

        private bool deslizando = false;
        private bool isDeforming = false;
        private bool posicionInicialRegistrada = false;

        private int tiempoTranscurrido = 0;

        public frmDibujoMovil()
        {
            InitializeComponent();
            groundLevel = pictureBox1.Height - radius;
            dataGridViewInfo.Columns.Add("Tiempo", "Tiempo (s)");
            dataGridViewInfo.Columns.Add("X", "X (m)");
            dataGridViewInfo.Columns.Add("Y", "Y (m)");
            dataGridViewInfo.Columns.Add("Altura", "Altura (m)");
            dataGridViewInfo.Columns.Add("Distancia", "Distancia (m)");
        }

        private float tiempoSimulado = 0f;
        private float tiempoParaRegistro = 0f;

        private void animationTimer_Tick(object sender, EventArgs e)
        {

            tiempoSimulado += 0.1f;
            tiempoParaRegistro += 0.1f;


            if (!deslizando)
                ballX += 2;


            velocityY += gravity;
            ballY += velocityY;


            if (ballY >= groundLevel)
            {
                ballY = groundLevel;
                velocityY = -velocityY * bounceFactor;
                isDeforming = true;
                deformation = 0.3f;

                if (Math.Abs(velocityY) < 1.5f)
                {
                    velocityY = 0;
                    deslizando = true;
                    isDeforming = false;
                }
            }

            if (isDeforming)
            {
                deformation -= 0.05f;
                if (deformation <= 0)
                {
                    deformation = 0;
                    isDeforming = false;
                }
            }

            if (!deslizando)
            {
                scaleY = 1 - deformation;
                scaleX = 1 + deformation;
            }


            if (deslizando)
            {
                ballX += deslizarVelocidad;

                if (scaleX > 1f)
                    scaleX -= 0.02f;
                if (scaleY < 1f)
                    scaleY += 0.02f;

                if (scaleX < 1f) scaleX = 1f;
                if (scaleY > 1f) scaleY = 1f;
            }

            float alturaMetros = (groundLevel - ballY) * metrosPorPixel;
            float distanciaMetros = (ballX - 50) * metrosPorPixel;
            lblAlturaSalida.Text = $"Altura: {alturaMetros:F2} m";
            lblDistanciaSalida.Text = $"Distancia: {distanciaMetros:F2} m";
            lblCoordenadas.Text = $"Coordenadas: ({distanciaMetros:F2} m, {alturaMetros:F2} m)";

            if (tiempoParaRegistro >= 0.1f)
            {
                tiempoParaRegistro = 0f;
                dataGridViewInfo.Rows.Add($"{tiempoSimulado:F1}s",
                    distanciaMetros.ToString("F2"),
                    alturaMetros.ToString("F2"),
                    alturaMetros.ToString("F2"),
                    distanciaMetros.ToString("F2"));
            }

            if (!posicionInicialRegistrada)
            {
                dataGridViewInfo.Rows.Clear();
                dataGridViewInfo.Columns.Clear();
                dataGridViewInfo.Columns.Add("Tiempo", "Tiempo");
                dataGridViewInfo.Columns.Add("X", "X");
                dataGridViewInfo.Columns.Add("Y", "Y");
                dataGridViewInfo.Columns.Add("Altura", "Altura");
                dataGridViewInfo.Columns.Add("Distancia", "Distancia");

                dataGridViewInfo.Rows.Add("0.0s", distanciaMetros.ToString("F2"),
                    alturaMetros.ToString("F2"), alturaMetros.ToString("F2"), distanciaMetros.ToString("F2"));
                posicionInicialRegistrada = true;
            }


            if (ballX > pictureBox1.Width - radius)
            {
                animationTimer.Stop();
                lblDistanciaSalida.Text += " (Fuera de vista)";
            }

            pictureBox1.Invalidate();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarAnimacion();
        }

        private void IniciarAnimacion()
        {
            tiempoSimulado = 0f;
            tiempoParaRegistro = 0f;

            if (!float.TryParse(txtAltura.Text, out float alturaMetros) || alturaMetros <= 0)
            {
                MessageBox.Show("Ingrese una altura válida (mayor que 0)");
                return;
            }

            if (!float.TryParse(txtVelocidad.Text, out float velocidadMetros) || velocidadMetros < 0)
            {
                MessageBox.Show("Ingrese una velocidad válida (mayor o igual a 0)");
                return;
            }

            ballX = 50;
            ballY = pictureBox1.Height - (alturaMetros * pixelPorMetro);
            velocityY = -velocidadMetros * pixelPorMetro * 0.1f;

            deformation = 0;
            scaleX = 1;
            scaleY = 1;
            isDeforming = false;
            deslizando = false;
            deslizarVelocidad = 2f;
            posicionInicialRegistrada = false;
            tiempoTranscurrido = 0;

            groundLevel = pictureBox1.Height - radius;

            lblAlturaSalida.Text = "Altura: 0 m";
            lblDistanciaSalida.Text = "Distancia: 0 m";
            lblCoordenadas.Text = "Coordenadas: (0, 0)";

            dataGridViewInfo.Rows.Clear();
            animationTimer.Start();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            Pen gridPen = new Pen(Color.Gray, 1);
            Pen axisPen = new Pen(Color.Black, 2);

            g.DrawLine(axisPen, 50, 0, 50, pictureBox1.Height);
            g.DrawLine(axisPen, 50, pictureBox1.Height, pictureBox1.Width, pictureBox1.Height);

            for (int i = 0; i <= pictureBox1.Width; i += 50)
            {
                g.DrawLine(gridPen, 50 + i, 0, 50 + i, pictureBox1.Height);
            }

            for (int i = 0; i <= pictureBox1.Height; i += 50)
            {
                g.DrawLine(gridPen, 0, pictureBox1.Height - i, pictureBox1.Width, pictureBox1.Height - i);
            }

            for (int i = 0; i <= pictureBox1.Width; i += 50)
            {
                g.DrawString((i * metrosPorPixel).ToString("F2") + " m", this.Font, Brushes.Black, 50 + i, pictureBox1.Height - 20);
            }

            for (int i = 0; i <= pictureBox1.Height; i += 50)
            {
                g.DrawString((i * metrosPorPixel).ToString("F2") + " m", this.Font, Brushes.Black, 5, pictureBox1.Height - i);
            }

            g.TranslateTransform(ballX, ballY);
            g.ScaleTransform(scaleX, scaleY);
            g.FillEllipse(Brushes.OrangeRed, -radius, -radius, radius * 2, radius * 2);
            g.ResetTransform();
        }
    }
}
