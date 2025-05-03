namespace FormsFractales
{
    partial class frmDibujoMovil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnIniciar = new Button();
            panel2 = new Panel();
            txtVelocidad = new TextBox();
            txtAltura = new TextBox();
            label1 = new Label();
            lblAlturaInicial = new Label();
            lblVelodicadInicial = new Label();
            panel1 = new Panel();
            lblDatosSalida = new Label();
            lblAlturaSalida = new Label();
            lblDistanciaSalida = new Label();
            lblCoordenadas = new Label();
            dataGridViewInfo = new DataGridView();
            pictureBox1 = new PictureBox();
            animationTimer = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(1099, 98);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(97, 29);
            btnIniciar.TabIndex = 14;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtVelocidad);
            panel2.Controls.Add(txtAltura);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblAlturaInicial);
            panel2.Controls.Add(lblVelodicadInicial);
            panel2.Location = new Point(687, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 151);
            panel2.TabIndex = 13;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(87, 80);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(230, 27);
            txtVelocidad.TabIndex = 7;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(66, 46);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(230, 27);
            txtAltura.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(321, 20);
            label1.TabIndex = 5;
            label1.Text = "Datos de salida: Altura y distancia en intervalos";
            // 
            // lblAlturaInicial
            // 
            lblAlturaInicial.AutoSize = true;
            lblAlturaInicial.Location = new Point(12, 49);
            lblAlturaInicial.Margin = new Padding(2, 0, 2, 0);
            lblAlturaInicial.Name = "lblAlturaInicial";
            lblAlturaInicial.Size = new Size(49, 20);
            lblAlturaInicial.TabIndex = 1;
            lblAlturaInicial.Text = "Altura";
            // 
            // lblVelodicadInicial
            // 
            lblVelodicadInicial.AutoSize = true;
            lblVelodicadInicial.Location = new Point(12, 83);
            lblVelodicadInicial.Margin = new Padding(2, 0, 2, 0);
            lblVelodicadInicial.Name = "lblVelodicadInicial";
            lblVelodicadInicial.Size = new Size(75, 20);
            lblVelodicadInicial.TabIndex = 2;
            lblVelodicadInicial.Text = "Velocidad";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDatosSalida);
            panel1.Controls.Add(lblAlturaSalida);
            panel1.Controls.Add(lblDistanciaSalida);
            panel1.Controls.Add(lblCoordenadas);
            panel1.Location = new Point(687, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 151);
            panel1.TabIndex = 12;
            // 
            // lblDatosSalida
            // 
            lblDatosSalida.AutoSize = true;
            lblDatosSalida.Location = new Point(12, 17);
            lblDatosSalida.Name = "lblDatosSalida";
            lblDatosSalida.Size = new Size(321, 20);
            lblDatosSalida.TabIndex = 5;
            lblDatosSalida.Text = "Datos de salida: Altura y distancia en intervalos";
            // 
            // lblAlturaSalida
            // 
            lblAlturaSalida.AutoSize = true;
            lblAlturaSalida.Location = new Point(12, 49);
            lblAlturaSalida.Margin = new Padding(2, 0, 2, 0);
            lblAlturaSalida.Name = "lblAlturaSalida";
            lblAlturaSalida.Size = new Size(49, 20);
            lblAlturaSalida.TabIndex = 1;
            lblAlturaSalida.Text = "Altura";
            // 
            // lblDistanciaSalida
            // 
            lblDistanciaSalida.AutoSize = true;
            lblDistanciaSalida.Location = new Point(12, 83);
            lblDistanciaSalida.Margin = new Padding(2, 0, 2, 0);
            lblDistanciaSalida.Name = "lblDistanciaSalida";
            lblDistanciaSalida.Size = new Size(70, 20);
            lblDistanciaSalida.TabIndex = 2;
            lblDistanciaSalida.Text = "Distancia";
            // 
            // lblCoordenadas
            // 
            lblCoordenadas.AutoSize = true;
            lblCoordenadas.Location = new Point(12, 115);
            lblCoordenadas.Margin = new Padding(2, 0, 2, 0);
            lblCoordenadas.Name = "lblCoordenadas";
            lblCoordenadas.Size = new Size(97, 20);
            lblCoordenadas.TabIndex = 4;
            lblCoordenadas.Text = "Coordenadas";
            // 
            // dataGridViewInfo
            // 
            dataGridViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo.Location = new Point(37, 429);
            dataGridViewInfo.Margin = new Padding(2);
            dataGridViewInfo.Name = "dataGridViewInfo";
            dataGridViewInfo.RowHeadersWidth = 62;
            dataGridViewInfo.Size = new Size(1159, 180);
            dataGridViewInfo.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 400);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // animationTimer
            // 
            animationTimer.Tick += animationTimer_Tick;
            // 
            // frmDibujoMovil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 622);
            Controls.Add(btnIniciar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewInfo);
            Controls.Add(pictureBox1);
            Name = "frmDibujoMovil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractal 01";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Panel panel2;
        private TextBox txtVelocidad;
        private TextBox txtAltura;
        private Label label1;
        private Label lblAlturaInicial;
        private Label lblVelodicadInicial;
        private Panel panel1;
        private Label lblDatosSalida;
        private Label lblAlturaSalida;
        private Label lblDistanciaSalida;
        private Label lblCoordenadas;
        private DataGridView dataGridViewInfo;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer animationTimer;
    }
}
