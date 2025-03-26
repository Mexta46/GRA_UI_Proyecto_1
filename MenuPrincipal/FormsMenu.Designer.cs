namespace MenuPrincipal
{
    partial class FormsMenu
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
            lblTitulo = new Label();
            btnMenu1 = new Button();
            btnMenu2 = new Button();
            btnMenu3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(347, 73);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(108, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menu principal";
            // 
            // btnMenu1
            // 
            btnMenu1.Location = new Point(146, 161);
            btnMenu1.Name = "btnMenu1";
            btnMenu1.Size = new Size(142, 57);
            btnMenu1.TabIndex = 1;
            btnMenu1.Text = "Menu 1\r\nconsola grafica";
            btnMenu1.UseVisualStyleBackColor = true;
            btnMenu1.Click += btnMenu1_Click;
            // 
            // btnMenu2
            // 
            btnMenu2.Location = new Point(328, 161);
            btnMenu2.Name = "btnMenu2";
            btnMenu2.Size = new Size(135, 57);
            btnMenu2.TabIndex = 2;
            btnMenu2.Text = "Menu 2\r\nconsola matrices";
            btnMenu2.UseVisualStyleBackColor = true;
            btnMenu2.Click += btnMenu2_Click;
            // 
            // btnMenu3
            // 
            btnMenu3.Location = new Point(502, 161);
            btnMenu3.Name = "btnMenu3";
            btnMenu3.Size = new Size(149, 57);
            btnMenu3.TabIndex = 3;
            btnMenu3.Text = "Menu 3\r\nfractales";
            btnMenu3.UseVisualStyleBackColor = true;
            btnMenu3.Click += btnMenu3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(146, 247);
            button4.Name = "button4";
            button4.Size = new Size(142, 52);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(328, 247);
            button5.Name = "button5";
            button5.Size = new Size(135, 52);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // FormsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnMenu3);
            Controls.Add(btnMenu2);
            Controls.Add(btnMenu1);
            Controls.Add(lblTitulo);
            Name = "FormsMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnMenu1;
        private Button btnMenu2;
        private Button btnMenu3;
        private Button button4;
        private Button button5;
    }
}