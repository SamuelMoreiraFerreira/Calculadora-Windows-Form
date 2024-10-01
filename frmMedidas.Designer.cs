namespace Calculadora
{
    partial class frmMedidas
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
            tbxCelsius = new TextBox();
            tbxFahrenheit = new TextBox();
            SuspendLayout();
            // 
            // tbxCelsius
            // 
            tbxCelsius.Location = new Point(12, 42);
            tbxCelsius.Name = "tbxCelsius";
            tbxCelsius.Size = new Size(100, 23);
            tbxCelsius.TabIndex = 0;
            // 
            // tbxFahrenheit
            // 
            tbxFahrenheit.Location = new Point(194, 42);
            tbxFahrenheit.Name = "tbxFahrenheit";
            tbxFahrenheit.Size = new Size(100, 23);
            tbxFahrenheit.TabIndex = 1;
            // 
            // frmMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxFahrenheit);
            Controls.Add(tbxCelsius);
            Name = "frmMedidas";
            Text = "frmMedidas";
            Load += frmMedidas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxCelsius;
        private TextBox tbxFahrenheit;
    }
}