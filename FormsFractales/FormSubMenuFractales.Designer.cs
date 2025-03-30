namespace MenuPrincipal
{
    partial class FormSubMenuFractales
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
            btnFractal1 = new Button();
            btnFractal2 = new Button();
            label1 = new Label();
            btnFractal3 = new Button();
            btnFractal4 = new Button();
            SuspendLayout();
            // 
            // btnFractal1
            // 
            btnFractal1.Location = new Point(159, 155);
            btnFractal1.Name = "btnFractal1";
            btnFractal1.Size = new Size(75, 23);
            btnFractal1.TabIndex = 0;
            btnFractal1.Text = "Fractal 1";
            btnFractal1.UseVisualStyleBackColor = true;
            btnFractal1.Click += btnFractal1_Click;
            // 
            // btnFractal2
            // 
            btnFractal2.Location = new Point(262, 155);
            btnFractal2.Name = "btnFractal2";
            btnFractal2.Size = new Size(75, 23);
            btnFractal2.TabIndex = 1;
            btnFractal2.Text = "Fractal 2";
            btnFractal2.UseVisualStyleBackColor = true;
            btnFractal2.Click += btnFractal2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 105);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Menu de Fractales";
            // 
            // btnFractal3
            // 
            btnFractal3.Location = new Point(159, 205);
            btnFractal3.Name = "btnFractal3";
            btnFractal3.Size = new Size(75, 23);
            btnFractal3.TabIndex = 3;
            btnFractal3.Text = "Fractal 3";
            btnFractal3.UseVisualStyleBackColor = true;
            btnFractal3.Click += btnFractal3_Click;
            // 
            // btnFractal4
            // 
            btnFractal4.Location = new Point(262, 205);
            btnFractal4.Name = "btnFractal4";
            btnFractal4.Size = new Size(75, 23);
            btnFractal4.TabIndex = 4;
            btnFractal4.Text = "Fractal 4";
            btnFractal4.UseVisualStyleBackColor = true;
            btnFractal4.Click += btnFractal4_Click;
            // 
            // FormSubMenuFractales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 338);
            Controls.Add(btnFractal4);
            Controls.Add(btnFractal3);
            Controls.Add(label1);
            Controls.Add(btnFractal2);
            Controls.Add(btnFractal1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSubMenuFractales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Fractales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFractal1;
        private Button btnFractal2;
        private Label label1;
        private Button btnFractal3;
        private Button btnFractal4;
    }
}