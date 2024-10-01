namespace Calculadora
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
            btnCalculadora = new Button();
            btnMedidas = new Button();
            SuspendLayout();
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(440, 108);
            btnCalculadora.Margin = new Padding(3, 2, 3, 2);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(113, 22);
            btnCalculadora.TabIndex = 0;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // btnMedidas
            // 
            btnMedidas.Location = new Point(294, 158);
            btnMedidas.Margin = new Padding(3, 2, 3, 2);
            btnMedidas.Name = "btnMedidas";
            btnMedidas.Size = new Size(113, 22);
            btnMedidas.TabIndex = 1;
            btnMedidas.Text = "Medidas";
            btnMedidas.UseVisualStyleBackColor = true;
            btnMedidas.Click += btnMedidas_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnMedidas);
            Controls.Add(btnCalculadora);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenu";
            Text = "frmMenu";
            FormClosed += frmMenu_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculadora;
        private Button btnMedidas;
    }
}