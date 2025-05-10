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
        List<Forma> listaFormas = new List<Forma>();
        Forma formaActual = new Forma();
        Color colorSeleccionado = Color.Black;
        int contadorFormas = 1;
        bool creandoForma = false;
        private bool mostrarFormaSeleccionada = false;
        private Forma formaElegida = null;
        private bool mostrarTodasLasFormas = false;
        private bool planoFueLimpiado = false;

        public frmTransformacines()
        {
            InitializeComponent();
        }

        private void frmTransformacines_Load(object sender, EventArgs e)
        {
            cmbReflexion.SelectedIndex = 0;
        }

        private void ActualizarLista()
        {
            int indice = Lista.SelectedIndex;
            Lista.Items.Clear();
            foreach (var forma in listaFormas)
                Lista.Items.Add(forma.Nombre);
            if (indice >= 0 && indice < Lista.Items.Count)
                Lista.SelectedIndex = indice;
        }

        private void LimpiarCoordenadas()
        {
            lblOriginalx.Text = "x:";
            lblOriginaly.Text = "y:";
            lblOriginalz.Text = "z:";
            lblTransformadax.Text = "x:";
            lblTransformaday.Text = "y:";
            lblTransformadaz.Text = "z:";
        }

        private void MostrarCoordenadas(Forma original, Forma transformada)
        {
            lblOriginalx.Text = "x:" + original.Puntos[0];
            lblOriginaly.Text = "y:" + original.Puntos[1];
            lblOriginalz.Text = "z:" + original.Puntos[2];
            lblTransformadax.Text = "x:" + transformada.Puntos[0];
            lblTransformaday.Text = "y:" + transformada.Puntos[1];
            lblTransformadaz.Text = "z:" + transformada.Puntos[2];
        }

        private void MostrarSoloOriginal(Forma original)
        {
            lblOriginalx.Text = "x:" + original.Puntos[0];
            lblOriginaly.Text = "y:" + original.Puntos[1];
            lblOriginalz.Text = "z:" + original.Puntos[2];
            lblTransformadax.Text = "x:";
            lblTransformaday.Text = "y:";
            lblTransformadaz.Text = "z:";
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una figura primero.");
                return;
            }

            if (!float.TryParse(txtAngulo.Text, out float angulo))
            {
                MessageBox.Show("Ingresa un ángulo válido.");
                return;
            }

            float radianes = angulo * (float)Math.PI / 180f;
            var original = listaFormas[Lista.SelectedIndex];
            var rotada = original.Clonar(original.Nombre + $"_Rot{angulo}°");

            foreach (var p in rotada.Puntos)
            {
                float x = p.X;
                float y = p.Y;
                p.X = x * (float)Math.Cos(radianes) - y * (float)Math.Sin(radianes);
                p.Y = x * (float)Math.Sin(radianes) + y * (float)Math.Cos(radianes);
            }

            listaFormas.Add(rotada);
            Plano.Invalidate();
            ActualizarLista();
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

            var original = listaFormas[Lista.SelectedIndex];
            string tipo = cmbReflexion.SelectedItem.ToString()!;
            var reflejada = original.Clonar(original.Nombre + $"_Ref_{tipo.Replace(" ", "")}");

            foreach (var p in reflejada.Puntos)
            {
                switch (tipo)
                {
                    case "Eje X": p.Y = -p.Y; break;
                    case "Eje Y": p.X = -p.X; break;
                    case "Origen": p.X = -p.X; p.Y = -p.Y; break;
                }
            }

            listaFormas.Add(reflejada);
            Plano.Invalidate();
            ActualizarLista();
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

            var original = listaFormas[Lista.SelectedIndex];
            var escalada = original.Clonar(original.Nombre + "_Esc");

            foreach (var p in escalada.Puntos)
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

            listaFormas.Add(escalada);
            Plano.Invalidate();
            ActualizarLista();
            MostrarCoordenadas(original, escalada);
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

            var original = listaFormas[Lista.SelectedIndex];
            var trasladada = original.Clonar(original.Nombre + "_T");

            foreach (var p in trasladada.Puntos)
            {
                p.X += dx;
                p.Y += dy;
            }

            listaFormas.Add(trasladada);
            Plano.Invalidate();
            ActualizarLista();
            MostrarCoordenadas(original, trasladada);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                colorSeleccionado = dlg.Color;
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            listaFormas.Clear();
            formaActual = new Forma();
            Plano.Invalidate();
            ActualizarLista();
            LimpiarCoordenadas();
        }

        private void btnIniciarFigura_Click(object sender, EventArgs e)
        {
            formaActual = new Forma();
            formaElegida = null;
            formaActual.Color = colorSeleccionado;
            creandoForma = true;

            mostrarFormaSeleccionada = !planoFueLimpiado;
            planoFueLimpiado = false;

            Plano.Invalidate();
        }

        private void btnFinalizarFigura_Click(object sender, EventArgs e)
        {
            if (formaActual.Puntos.Count < 3)
            {
                MessageBox.Show("Debe haber al menos 3 puntos para una figura.");
                return;
            }

            formaActual.Nombre = $"Figura {contadorFormas++}";
            formaActual.Color = colorSeleccionado;

            listaFormas.Add(formaActual);
            formaActual = new Forma();
            creandoForma = false;

            Plano.Invalidate();
            ActualizarLista();
        }

        private void btnLimpiarPlano_Click(object sender, EventArgs e)
        {
            mostrarFormaSeleccionada = false;
            formaElegida = null;
            planoFueLimpiado = true;
            Plano.Invalidate();
        }

        private void Plano_MouseClick(object sender, MouseEventArgs e)
        {
            if (!creandoForma) return;
            int x = e.X - Plano.Width / 2;
            int y = -(e.Y - Plano.Height / 2);
            formaActual.Puntos.Add(new Punto(x, y));
            Plano.Invalidate();
        }

        private void Plano_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TranslateTransform(Plano.Width / 2, Plano.Height / 2);
            int paso = 20;
            Font fuente = new Font("Arial", 8);
            Brush pincel = Brushes.Black;
            Pen lapizGuia = new Pen(Color.Gray, 1);

            for (int x = -Plano.Width / 2; x <= Plano.Width / 2; x += paso)
            {
                if (x == 0) continue;
                g.DrawLine(lapizGuia, x, -3, x, 3);
                g.DrawString(x.ToString(), fuente, pincel, x - 10, 5);
            }

            for (int y = -Plano.Height / 2; y <= Plano.Height / 2; y += paso)
            {
                if (y == 0) continue;
                g.DrawLine(lapizGuia, -3, -y, 3, -y);
                g.DrawString(y.ToString(), fuente, pincel, 5, -y - 7);
            }

            using var lapizEjes = new Pen(Color.LightGray, 1);
            g.DrawLine(lapizEjes, -Plano.Width / 2, 0, Plano.Width / 2, 0);
            g.DrawLine(lapizEjes, 0, -Plano.Height / 2, 0, Plano.Height / 2);

            if (mostrarFormaSeleccionada && formaElegida != null)
            {
                if (formaElegida.Puntos.Count > 1)
                {
                    var puntos = formaElegida.Puntos.Select(p => new PointF(p.X, -p.Y)).ToArray();
                    using var lapiz = new Pen(formaElegida.Color, 2);
                    g.DrawPolygon(lapiz, puntos);
                }

                foreach (var punto in formaElegida.Puntos)
                    g.FillEllipse(new SolidBrush(formaElegida.Color), punto.X - 2, -punto.Y - 2, 4, 4);
            }

            if (formaActual != null && formaActual.Puntos.Count > 0)
            {
                foreach (var forma in listaFormas.Append(formaActual))
                {
                    if (forma.Puntos.Count > 1)
                    {
                        var puntos = forma.Puntos.Select(p => new PointF(p.X, -p.Y)).ToArray();
                        using var lapiz = new Pen(forma.Color, 2);
                        g.DrawPolygon(lapiz, puntos);
                    }

                    foreach (var punto in forma.Puntos)
                        g.FillEllipse(new SolidBrush(forma.Color), punto.X - 2, -punto.Y - 2, 4, 4);
                }
            }

            if (mostrarTodasLasFormas)
            {
                foreach (var forma in listaFormas)
                {
                    if (forma.Puntos.Count > 1)
                    {
                        var puntos = forma.Puntos.Select(p => new PointF(p.X, -p.Y)).ToArray();
                        using var lapiz = new Pen(forma.Color, 2);
                        g.DrawPolygon(lapiz, puntos);
                    }

                    foreach (var punto in forma.Puntos)
                        g.FillEllipse(new SolidBrush(forma.Color), punto.X - 2, -punto.Y - 2, 4, 4);
                }
            }
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex != -1)
            {
                formaElegida = listaFormas[Lista.SelectedIndex];
                mostrarFormaSeleccionada = true;
                Plano.Invalidate();

                var seleccionada = formaElegida;
                var original = listaFormas.FirstOrDefault(f => seleccionada.Nombre.StartsWith(f.Nombre) && f != seleccionada);

                if (original != null && seleccionada.Nombre.StartsWith(original.Nombre))
                {
                    MostrarCoordenadas(original, seleccionada);
                }
                else
                {
                    MostrarSoloOriginal(seleccionada);
                }
            }
        }

        private void rbtMostrarEn_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTodasLasFormas = rbtMostrarEn.Checked;
            Plano.Invalidate();
        }

        public class Punto
        {
            public float X { get; set; }
            public float Y { get; set; }
            public Punto(float x, float y) { X = x; Y = y; }
            public override string ToString() => $"({X:F2},{Y:F2})";
        }

        public class Forma
        {
            public string Nombre { get; set; } = "";
            public List<Punto> Puntos { get; set; } = new List<Punto>();
            public Color Color { get; set; }

            public Forma Clonar(string nuevoNombre)
            {
                return new Forma
                {
                    Nombre = nuevoNombre,
                    Color = this.Color,
                    Puntos = this.Puntos.Select(p => new Punto(p.X, p.Y)).ToList()
                };
            }
        }
    }
}
