namespace FormsGraficos
{
    partial class frmTransformacines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbReflexion = new ComboBox();
            txtPuntoFijoX = new TextBox();
            txtPuntoFijoY = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtAngulo = new TextBox();
            chkPuntoFijo = new CheckBox();
            txtPy = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtPx = new TextBox();
            txtSy = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtSx = new TextBox();
            btnIniciarFigura = new Button();
            btnFinalizarFigura = new Button();
            btnReflexion = new Button();
            btnRotar = new Button();
            btnEscalar = new Button();
            dgvCoordenadas = new DataGridView();
            Original = new DataGridViewTextBoxColumn();
            Transformada = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            txtDy = new TextBox();
            txtDx = new TextBox();
            Lista = new ListBox();
            btnLimpiarTodo = new Button();
            btnLimpiarPlano = new Button();
            btnColor = new Button();
            btnTrasladar = new Button();
            Plano = new PictureBox();
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            rbtMostrarDis = new RadioButton();
            rbtMostrarEn = new RadioButton();
            panel4 = new Panel();
            label13 = new Label();
            panel5 = new Panel();
            label14 = new Label();
            panel6 = new Panel();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCoordenadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plano).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // cmbReflexion
            // 
            cmbReflexion.FormattingEnabled = true;
            cmbReflexion.Items.AddRange(new object[] { "Eje X", "Eje Y", "Origen" });
            cmbReflexion.Location = new Point(12, 53);
            cmbReflexion.Margin = new Padding(2);
            cmbReflexion.Name = "cmbReflexion";
            cmbReflexion.Size = new Size(146, 28);
            cmbReflexion.TabIndex = 64;
            // 
            // txtPuntoFijoX
            // 
            txtPuntoFijoX.Location = new Point(13, 148);
            txtPuntoFijoX.Margin = new Padding(2);
            txtPuntoFijoX.Name = "txtPuntoFijoX";
            txtPuntoFijoX.Size = new Size(121, 27);
            txtPuntoFijoX.TabIndex = 63;
            // 
            // txtPuntoFijoY
            // 
            txtPuntoFijoY.Location = new Point(13, 227);
            txtPuntoFijoY.Margin = new Padding(2);
            txtPuntoFijoY.Name = "txtPuntoFijoY";
            txtPuntoFijoY.Size = new Size(121, 27);
            txtPuntoFijoY.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 196);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 61;
            label9.Text = "Punto fijo en Y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 117);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 60;
            label8.Text = "Punto fijo en X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 51);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 59;
            label7.Text = "Ángulo";
            // 
            // txtAngulo
            // 
            txtAngulo.Location = new Point(13, 74);
            txtAngulo.Margin = new Padding(2);
            txtAngulo.Name = "txtAngulo";
            txtAngulo.Size = new Size(121, 27);
            txtAngulo.TabIndex = 58;
            // 
            // chkPuntoFijo
            // 
            chkPuntoFijo.AutoSize = true;
            chkPuntoFijo.Location = new Point(162, 194);
            chkPuntoFijo.Margin = new Padding(2);
            chkPuntoFijo.Name = "chkPuntoFijo";
            chkPuntoFijo.Size = new Size(129, 24);
            chkPuntoFijo.TabIndex = 57;
            chkPuntoFijo.Text = "Usar punto fijo";
            chkPuntoFijo.UseVisualStyleBackColor = true;
            // 
            // txtPy
            // 
            txtPy.Location = new Point(14, 301);
            txtPy.Margin = new Padding(2);
            txtPy.Name = "txtPy";
            txtPy.Size = new Size(121, 27);
            txtPy.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 275);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 55;
            label6.Text = "Punto fijo en Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 202);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 54;
            label5.Text = "Punto fijo en X";
            // 
            // txtPx
            // 
            txtPx.Location = new Point(10, 232);
            txtPx.Margin = new Padding(2);
            txtPx.Name = "txtPx";
            txtPx.Size = new Size(121, 27);
            txtPx.TabIndex = 53;
            // 
            // txtSy
            // 
            txtSy.Location = new Point(10, 157);
            txtSy.Margin = new Padding(2);
            txtSy.Name = "txtSy";
            txtSy.Size = new Size(121, 27);
            txtSy.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 125);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 51;
            label4.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 50;
            label3.Text = "X";
            // 
            // txtSx
            // 
            txtSx.Location = new Point(10, 90);
            txtSx.Margin = new Padding(2);
            txtSx.Name = "txtSx";
            txtSx.Size = new Size(121, 27);
            txtSx.TabIndex = 49;
            // 
            // btnIniciarFigura
            // 
            btnIniciarFigura.Location = new Point(12, 68);
            btnIniciarFigura.Margin = new Padding(2);
            btnIniciarFigura.Name = "btnIniciarFigura";
            btnIniciarFigura.Size = new Size(126, 27);
            btnIniciarFigura.TabIndex = 48;
            btnIniciarFigura.Text = "Iniciar figura";
            btnIniciarFigura.UseVisualStyleBackColor = true;
            btnIniciarFigura.Click += btnIniciarFigura_Click;
            // 
            // btnFinalizarFigura
            // 
            btnFinalizarFigura.Location = new Point(162, 68);
            btnFinalizarFigura.Margin = new Padding(2);
            btnFinalizarFigura.Name = "btnFinalizarFigura";
            btnFinalizarFigura.Size = new Size(167, 27);
            btnFinalizarFigura.TabIndex = 47;
            btnFinalizarFigura.Text = "Guardar figura";
            btnFinalizarFigura.UseVisualStyleBackColor = true;
            btnFinalizarFigura.Click += btnFinalizarFigura_Click;
            // 
            // btnReflexion
            // 
            btnReflexion.BackColor = Color.White;
            btnReflexion.Location = new Point(12, 100);
            btnReflexion.Margin = new Padding(2);
            btnReflexion.Name = "btnReflexion";
            btnReflexion.Size = new Size(90, 27);
            btnReflexion.TabIndex = 46;
            btnReflexion.Text = "Reflejar";
            btnReflexion.UseVisualStyleBackColor = false;
            btnReflexion.Click += btnReflexion_Click;
            // 
            // btnRotar
            // 
            btnRotar.BackColor = Color.White;
            btnRotar.Location = new Point(10, 275);
            btnRotar.Margin = new Padding(2);
            btnRotar.Name = "btnRotar";
            btnRotar.Size = new Size(60, 27);
            btnRotar.TabIndex = 45;
            btnRotar.Text = "Rotar";
            btnRotar.UseVisualStyleBackColor = false;
            btnRotar.Click += btnRotar_Click;
            // 
            // btnEscalar
            // 
            btnEscalar.BackColor = Color.White;
            btnEscalar.Location = new Point(12, 343);
            btnEscalar.Margin = new Padding(2);
            btnEscalar.Name = "btnEscalar";
            btnEscalar.Size = new Size(90, 27);
            btnEscalar.TabIndex = 44;
            btnEscalar.Text = "Escalado";
            btnEscalar.UseVisualStyleBackColor = false;
            btnEscalar.Click += btnEscalar_Click;
            // 
            // dgvCoordenadas
            // 
            dgvCoordenadas.AllowUserToAddRows = false;
            dgvCoordenadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoordenadas.Columns.AddRange(new DataGridViewColumn[] { Original, Transformada });
            dgvCoordenadas.Location = new Point(809, 314);
            dgvCoordenadas.Margin = new Padding(2);
            dgvCoordenadas.Name = "dgvCoordenadas";
            dgvCoordenadas.ReadOnly = true;
            dgvCoordenadas.RowHeadersWidth = 62;
            dgvCoordenadas.Size = new Size(355, 236);
            dgvCoordenadas.TabIndex = 43;
            // 
            // Original
            // 
            Original.HeaderText = "Original";
            Original.MinimumWidth = 8;
            Original.Name = "Original";
            Original.ReadOnly = true;
            Original.Width = 150;
            // 
            // Transformada
            // 
            Transformada.HeaderText = "Transformada";
            Transformada.MinimumWidth = 8;
            Transformada.Name = "Transformada";
            Transformada.ReadOnly = true;
            Transformada.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 131);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 42;
            label2.Text = "Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 41;
            label1.Text = "X";
            // 
            // txtDy
            // 
            txtDy.Location = new Point(13, 154);
            txtDy.Margin = new Padding(2);
            txtDy.Name = "txtDy";
            txtDy.Size = new Size(121, 27);
            txtDy.TabIndex = 40;
            // 
            // txtDx
            // 
            txtDx.Location = new Point(13, 90);
            txtDx.Margin = new Padding(2);
            txtDx.Name = "txtDx";
            txtDx.Size = new Size(121, 27);
            txtDx.TabIndex = 39;
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.Location = new Point(792, 574);
            Lista.Margin = new Padding(2);
            Lista.Name = "Lista";
            Lista.Size = new Size(194, 164);
            Lista.TabIndex = 38;
            Lista.SelectedIndexChanged += Lista_SelectedIndexChanged;
            // 
            // btnLimpiarTodo
            // 
            btnLimpiarTodo.Location = new Point(12, 134);
            btnLimpiarTodo.Margin = new Padding(2);
            btnLimpiarTodo.Name = "btnLimpiarTodo";
            btnLimpiarTodo.Size = new Size(128, 27);
            btnLimpiarTodo.TabIndex = 37;
            btnLimpiarTodo.Text = "Limpiar todo";
            btnLimpiarTodo.UseVisualStyleBackColor = true;
            btnLimpiarTodo.Click += btnLimpiarTodo_Click;
            // 
            // btnLimpiarPlano
            // 
            btnLimpiarPlano.Location = new Point(162, 134);
            btnLimpiarPlano.Margin = new Padding(2);
            btnLimpiarPlano.Name = "btnLimpiarPlano";
            btnLimpiarPlano.Size = new Size(134, 27);
            btnLimpiarPlano.TabIndex = 36;
            btnLimpiarPlano.Text = "Limpiar plano";
            btnLimpiarPlano.UseVisualStyleBackColor = true;
            btnLimpiarPlano.Click += btnLimpiarPlano_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(12, 191);
            btnColor.Margin = new Padding(2);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(90, 27);
            btnColor.TabIndex = 35;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnTrasladar
            // 
            btnTrasladar.BackColor = Color.White;
            btnTrasladar.Location = new Point(13, 200);
            btnTrasladar.Margin = new Padding(2);
            btnTrasladar.Name = "btnTrasladar";
            btnTrasladar.Size = new Size(90, 27);
            btnTrasladar.TabIndex = 34;
            btnTrasladar.Text = "Trasladar";
            btnTrasladar.UseVisualStyleBackColor = false;
            btnTrasladar.Click += btnTrasladar_Click;
            // 
            // Plano
            // 
            Plano.BorderStyle = BorderStyle.FixedSingle;
            Plano.Location = new Point(21, 13);
            Plano.Margin = new Padding(2);
            Plano.Name = "Plano";
            Plano.Size = new Size(748, 724);
            Plano.TabIndex = 33;
            Plano.TabStop = false;
            Plano.Paint += Plano_Paint;
            Plano.MouseClick += Plano_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtPuntoFijoX);
            panel1.Controls.Add(btnRotar);
            panel1.Controls.Add(txtAngulo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPuntoFijoY);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1195, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 312);
            panel1.TabIndex = 66;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 16);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 64;
            label10.Text = "Rotacion";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 122, 123);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cmbReflexion);
            panel2.Controls.Add(btnReflexion);
            panel2.Location = new Point(1363, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(166, 137);
            panel2.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 21);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 65;
            label11.Text = "Reflexión";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 12);
            label12.Name = "label12";
            label12.Size = new Size(172, 20);
            label12.TabIndex = 68;
            label12.Text = "Mostrar todas las figuras";
            // 
            // panel3
            // 
            panel3.Controls.Add(rbtMostrarDis);
            panel3.Controls.Add(rbtMostrarEn);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(991, 574);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 125);
            panel3.TabIndex = 69;
            // 
            // rbtMostrarDis
            // 
            rbtMostrarDis.AutoSize = true;
            rbtMostrarDis.Checked = true;
            rbtMostrarDis.Location = new Point(15, 74);
            rbtMostrarDis.Name = "rbtMostrarDis";
            rbtMostrarDis.Size = new Size(62, 24);
            rbtMostrarDis.TabIndex = 70;
            rbtMostrarDis.TabStop = true;
            rbtMostrarDis.Text = "False";
            rbtMostrarDis.UseVisualStyleBackColor = true;
            // 
            // rbtMostrarEn
            // 
            rbtMostrarEn.AutoSize = true;
            rbtMostrarEn.Location = new Point(15, 44);
            rbtMostrarEn.Name = "rbtMostrarEn";
            rbtMostrarEn.Size = new Size(58, 24);
            rbtMostrarEn.TabIndex = 69;
            rbtMostrarEn.Text = "True";
            rbtMostrarEn.UseVisualStyleBackColor = true;
            rbtMostrarEn.CheckedChanged += rbtMostrarEn_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(99, 113, 122);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(btnEscalar);
            panel4.Controls.Add(txtSx);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtSy);
            panel4.Controls.Add(txtPy);
            panel4.Controls.Add(txtPx);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(1363, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(166, 383);
            panel4.TabIndex = 70;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(10, 18);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 57;
            label13.Text = "Escalar";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(165, 136, 136);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(btnTrasladar);
            panel5.Controls.Add(txtDx);
            panel5.Controls.Add(txtDy);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(1195, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(151, 240);
            panel5.TabIndex = 71;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 18);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 43;
            label14.Text = "Traslación";
            // 
            // panel6
            // 
            panel6.Controls.Add(label15);
            panel6.Controls.Add(btnIniciarFigura);
            panel6.Controls.Add(btnColor);
            panel6.Controls.Add(btnLimpiarPlano);
            panel6.Controls.Add(btnLimpiarTodo);
            panel6.Controls.Add(btnFinalizarFigura);
            panel6.Controls.Add(chkPuntoFijo);
            panel6.Location = new Point(809, 34);
            panel6.Name = "panel6";
            panel6.Size = new Size(339, 238);
            panel6.TabIndex = 72;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 13);
            label15.Name = "label15";
            label15.Size = new Size(72, 20);
            label15.TabIndex = 58;
            label15.Text = "Controles";
            // 
            // frmTransformacines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 748);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvCoordenadas);
            Controls.Add(Lista);
            Controls.Add(Plano);
            Name = "frmTransformacines";
            Text = "frmTransformacines";
            Load += frmTransformacines_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoordenadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plano).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbReflexion;
        private TextBox txtPuntoFijoX;
        private TextBox txtPuntoFijoY;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtAngulo;
        private CheckBox chkPuntoFijo;
        private TextBox txtPy;
        private Label label6;
        private Label label5;
        private TextBox txtPx;
        private TextBox txtSy;
        private Label label4;
        private Label label3;
        private TextBox txtSx;
        private Button btnIniciarFigura;
        private Button btnFinalizarFigura;
        private Button btnReflexion;
        private Button btnRotar;
        private Button btnEscalar;
        private DataGridView dgvCoordenadas;
        private DataGridViewTextBoxColumn Original;
        private DataGridViewTextBoxColumn Transformada;
        private Label label2;
        private Label label1;
        private TextBox txtDy;
        private TextBox txtDx;
        private ListBox Lista;
        private Button btnLimpiarTodo;
        private Button btnLimpiarPlano;
        private Button btnColor;
        private Button btnTrasladar;
        private PictureBox Plano;
        private Panel panel1;
        private Label label10;
        private Panel panel2;
        private Label label11;
        private Label label12;
        private Panel panel3;
        private RadioButton rbtMostrarDis;
        private RadioButton rbtMostrarEn;
        private Panel panel4;
        private Label label13;
        private Panel panel5;
        private Label label14;
        private Panel panel6;
        private Label label15;
    }
}