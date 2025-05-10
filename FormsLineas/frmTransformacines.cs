using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGraficos
{
    public partial class frmTransformacines : Form
    {
        List<Figura> figuras = new List<Figura>();
        Figura figuraActual = new Figura();
        Color colorActual = Color.Black;
        int contadorFiguras = 1;
        bool construyendoFigura = false;
        private bool mostrarFiguras = false;
        private Figura figuraSeleccionada = null;
        private bool mostrarTodasLasFiguras = false;
        private bool planoLimpiado = false;
        public frmTransformacines()
        {
            InitializeComponent();
        }

        private void frmTransformacines_Load(object sender, EventArgs e)
        {
            cmbReflexion.SelectedIndex = 0;
        }

        private void ActualizarHistorial()
        {
            int indiceSeleccionado = Lista.SelectedIndex;

            Lista.Items.Clear();
            foreach (var figura in figuras)
                Lista.Items.Add(figura.Nombre);

            if (indiceSeleccionado >= 0 && indiceSeleccionado < Lista.Items.Count)
                Lista.SelectedIndex = indiceSeleccionado;
        }

        private void limpiarCoordenadas()
        {

        }

        private void MostrarCoordenadas(Figura original, Figura transformada)
        {
            dgvCoordenadas.Rows.Clear();
            for (int i = 0; i < original.Puntos.Count; i++)
            {
                dgvCoordenadas.Rows.Add(original.Puntos[i], transformada.Puntos[i]);
            }
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una figura primero.");
                return;
            }

            if (!float.TryParse(txtAngulo.Text, out float anguloGrados))
            {
                MessageBox.Show("Ingresa un ángulo válido.");
                return;
            }

            // Convertir a radianes
            float anguloRadianes = anguloGrados * (float)Math.PI / 180f;

            var original = figuras[Lista.SelectedIndex];
            var rotada = original.Clone(original.Nombre + $"_Rot{anguloGrados}°");

            foreach (var p in rotada.Puntos)
            {
                float x = p.X;
                float y = p.Y;

                // Rotación respecto al origen
                p.X = x * (float)Math.Cos(anguloRadianes) - y * (float)Math.Sin(anguloRadianes);
                p.Y = x * (float)Math.Sin(anguloRadianes) + y * (float)Math.Cos(anguloRadianes);
            }

            figuras.Add(rotada);
            Plano.Invalidate();
            ActualizarHistorial();
            MostrarCoordenadas(original, rotada);
        }

        private void btnReflexion_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una figura primero.");
                return;
            }

            if (cmbReflexion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de reflexión.");
                return;
            }

            var original = figuras[Lista.SelectedIndex];
            string tipo = cmbReflexion.SelectedItem.ToString()!;
            var reflejada = original.Clone(original.Nombre + $"_Ref_{tipo.Replace(" ", "")}");

            foreach (var p in reflejada.Puntos)
            {
                switch (tipo)
                {
                    case "Eje X":
                        p.Y = -p.Y;
                        break;
                    case "Eje Y":
                        p.X = -p.X;
                        break;
                    case "Origen":
                        p.X = -p.X;
                        p.Y = -p.Y;
                        break;
                }
            }

            figuras.Add(reflejada);
            Plano.Invalidate();
            ActualizarHistorial();
            MostrarCoordenadas(original, reflejada);
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una figura primero.");
                return;
            }

            if (!float.TryParse(txtSx.Text, out float sx) || !float.TryParse(txtSy.Text, out float sy))
            {
                MessageBox.Show("Ingresa valores válidos para Sx y Sy.");
                return;
            }

            float px = 0, py = 0;

            if (chkPuntoFijo.Checked)
            {
                if (!float.TryParse(txtPx.Text, out px) || !float.TryParse(txtPy.Text, out py))
                {
                    MessageBox.Show("Ingresa valores válidos para el punto fijo.");
                    return;
                }
            }

            var original = figuras[Lista.SelectedIndex];
            var transformada = original.Clone(original.Nombre + "_Esc");

            foreach (var p in transformada.Puntos)
            {
                if (chkPuntoFijo.Checked)
                {
                    p.X = sx * (p.X - px) + px;
                    p.Y = sy * (p.Y - py) + py;
                }
                else
                {
                    p.X *= sx;
                    p.Y *= sy;
                }
            }

            figuras.Add(transformada);
            Plano.Invalidate();
            ActualizarHistorial();
            MostrarCoordenadas(original, transformada);
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una figura primero.");
                return;
            }

            float dx = float.Parse(txtDx.Text);
            float dy = float.Parse(txtDy.Text);

            var original = figuras[Lista.SelectedIndex];
            var transformada = original.Clone(original.Nombre + "_T");

            foreach (var p in transformada.Puntos)
            {
                p.X += dx;
                p.Y += dy;
            }

            figuras.Add(transformada);
            Plano.Invalidate();
            ActualizarHistorial();
            MostrarCoordenadas(original, transformada);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                colorActual = dlg.Color;
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            figuras.Clear();
            figuraActual = new Figura();
            Plano.Invalidate();
            ActualizarHistorial();
        }

        private void btnIniciarFigura_Click(object sender, EventArgs e)
        {
            figuraActual = new Figura();
            figuraSeleccionada = null;
            figuraActual.Color = colorActual; // color actual elegido
            construyendoFigura = true;

            if (!planoLimpiado)
            {
                mostrarFiguras = true; // Mostrar figuras anteriores
            }
            else
            {
                mostrarFiguras = false; // No mostrar figuras si se limpió el plano
                planoLimpiado = false; // Ya empezamos una nueva figura, quitamos bandera
            }

            Plano.Invalidate(); // Redibuja el canvas
        }

        private void btnFinalizarFigura_Click(object sender, EventArgs e)
        {
            if (figuraActual.Puntos.Count < 3)
            {
                MessageBox.Show("Debe haber al menos 3 puntos para una figura.");
                return;
            }

            figuraActual.Nombre = $"Figura {contadorFiguras++}";
            figuraActual.Color = colorActual;

            figuras.Add(figuraActual);
            figuraActual = new Figura();
            construyendoFigura = false;
            Plano.Invalidate();

            ActualizarHistorial();
        }

        private void btnLimpiarPlano_Click(object sender, EventArgs e)
        {
            mostrarFiguras = false;  // Ocultar figuras dibujadas
            figuraSeleccionada = null;
            planoLimpiado = true;
            Plano.Invalidate();
        }

        private void Plano_MouseClick(object sender, MouseEventArgs e)
        {
            if (!construyendoFigura) return;

            // Convertimos a coordenadas centradas
            int x = e.X - Plano.Width / 2;
            int y = -(e.Y - Plano.Height / 2); // Se invierte el eje Y

            figuraActual.Puntos.Add(new Punto(x, y));
            Plano.Invalidate(); // Redibuja el canvas
        }

        private void Plano_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            // Mover origen al centro del PictureBox
            g.TranslateTransform(Plano.Width / 2, Plano.Height / 2);

            // Dibuja marcas numéricas en los ejes
            int step = 20; // distancia entre marcas (en píxeles/cartesiano)
            Font font = new Font("Arial", 8);
            Brush brush = Brushes.Black;
            Pen tickPen = new Pen(Color.Gray, 1);

            // Eje X (horizontal)
            for (int x = -Plano.Width / 2; x <= Plano.Width / 2; x += step)
            {
                if (x == 0) continue; // Evitar solapar el origen

                // Dibujar la línea de la marca
                g.DrawLine(tickPen, x, -3, x, 3);

                // Dibujar la etiqueta (coordenada)
                g.DrawString(x.ToString(), font, brush, x - 10, 5);
            }

            // Eje Y (vertical)
            for (int y = -Plano.Height / 2; y <= Plano.Height / 2; y += step)
            {
                if (y == 0) continue;

                // Dibujar la línea de la marca
                g.DrawLine(tickPen, -3, -y, 3, -y);

                // Dibujar la etiqueta (coordenada)
                g.DrawString(y.ToString(), font, brush, 5, -y - 7);
            }




            // Dibujar ejes si quieres
            using var ejePen = new Pen(Color.LightGray, 1);
            g.DrawLine(ejePen, -Plano.Width / 2, 0, Plano.Width / 2, 0); // eje X
            g.DrawLine(ejePen, 0, -Plano.Height / 2, 0, Plano.Height / 2); // eje Y

            // Solo mostrar la figura seleccionada si se indicó
            if (mostrarFiguras && figuraSeleccionada != null)
            {
                if (figuraSeleccionada.Puntos.Count > 1)
                {
                    var puntos = figuraSeleccionada.Puntos.Select(p => new PointF(p.X, -p.Y)).ToArray();
                    using var pen = new Pen(figuraSeleccionada.Color, 2);
                    g.DrawPolygon(pen, puntos);
                }

                foreach (var punto in figuraSeleccionada.Puntos)
                {
                    g.FillEllipse(new SolidBrush(figuraSeleccionada.Color), punto.X - 2, -punto.Y - 2, 4, 4);
                }
            }

            if (figuraActual != null && figuraActual.Puntos.Count > 0)
            {
                // Ahora sí dibujamos las figuras
                foreach (var figura in figuras.Append(figuraActual))
                {
                    if (figura.Puntos.Count > 1)
                    {
                        var puntos = figura.Puntos.Select(p => new PointF(p.X, -p.Y)).ToArray();
                        using var pen = new Pen(figura.Color, 2);
                        g.DrawPolygon(pen, puntos);
                    }

                    foreach (var punto in figura.Puntos)
                    {
                        g.FillEllipse(new SolidBrush(figura.Color), punto.X - 2, -punto.Y - 2, 4, 4);
                    }
                }
            }
            // Dibujar todas las figuras si el checkbox está activado
            if (mostrarTodasLasFiguras)
            {
                foreach (var figura in figuras)
                {
                    if (figura.Puntos.Count > 1)
                    {
                        var puntos = figura.Puntos.Select(p => new PointF(p.X, -p.Y)).ToArray();
                        using var pen = new Pen(figura.Color, 2);
                        g.DrawPolygon(pen, puntos);
                    }

                    foreach (var punto in figura.Puntos)
                    {
                        g.FillEllipse(new SolidBrush(figura.Color), punto.X - 2, -punto.Y - 2, 4, 4);
                    }
                }
            }
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex != -1)
            {
                figuraSeleccionada = figuras[Lista.SelectedIndex];
                mostrarFiguras = true;
                Plano.Invalidate(); // Redibuja solo esa figura
            }
        }

        private void rbtMostrarEn_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTodasLasFiguras = rbtMostrarEn.Checked;
            Plano.Invalidate(); // Aquí sí redibuja el canvas correcto
        }


        public class Punto
        {
            public float X { get; set; }
            public float Y { get; set; }
            public Punto(float x, float y)
            {
                X = x;
                Y = y;
            }
            public override string ToString() => $"({X:F2},{Y:F2})";
        }
        public class Figura
        {
            public string Nombre { get; set; } = "";
            public List<Punto> Puntos { get; set; } = new List<Punto>();
            public Color Color { get; set; }

            public Figura Clone(string nuevoNombre)
            {
                return new Figura
                {
                    Nombre = nuevoNombre,
                    Color = this.Color,
                    Puntos = this.Puntos.Select(p => new Punto(p.X, p.Y)).ToList()
                };
            }
        }
    }
}
