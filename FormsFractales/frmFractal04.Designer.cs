namespace FormsFractales
{
    partial class frmFractal04
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
            ptbMandelbrot = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbMandelbrot).BeginInit();
            SuspendLayout();
            // 
            // ptbMandelbrot
            // 
            ptbMandelbrot.Location = new Point(110, 10);
            ptbMandelbrot.Margin = new Padding(3, 2, 3, 2);
            ptbMandelbrot.Name = "ptbMandelbrot";
            ptbMandelbrot.Size = new Size(481, 412);
            ptbMandelbrot.TabIndex = 3;
            ptbMandelbrot.TabStop = false;
            // 
            // frmFractal04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 432);
            Controls.Add(ptbMandelbrot);
            Name = "frmFractal04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractal 04";
            Load += frmFractal04_Load;
            ((System.ComponentModel.ISupportInitialize)ptbMandelbrot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbMandelbrot;
    }
}