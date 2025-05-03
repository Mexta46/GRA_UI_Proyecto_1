namespace FormsGraficos
{
    partial class frmMenu
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
            btnMenu1 = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnMenu1
            // 
            btnMenu1.Location = new Point(148, 200);
            btnMenu1.Name = "btnMenu1";
            btnMenu1.Size = new Size(142, 57);
            btnMenu1.TabIndex = 7;
            btnMenu1.Text = "Menu 1\r\nGrafica movil";
            btnMenu1.UseVisualStyleBackColor = true;
            btnMenu1.Click += btnMenu1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(349, 112);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(124, 20);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Menu de graficos";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu1);
            Controls.Add(lblTitulo);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMenu1;
        private Label lblTitulo;
    }
}