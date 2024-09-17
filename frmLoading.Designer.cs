namespace Calculadora
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            pgbCarregamento = new ProgressBar();
            lblLoading = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();

            // 
            // pgbCarregamento
            // 
            pgbCarregamento.Location = new Point(12, 390);
            pgbCarregamento.Name = "pgbCarregamento";
            pgbCarregamento.Size = new Size(360, 59);
            pgbCarregamento.TabIndex = 0;
            pgbCarregamento.Value = 100;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.BackColor = Color.Transparent;
            lblLoading.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoading.Location = new Point(134, 350);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(111, 38);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "Loading";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.dio;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(190, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 452);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.jotaro;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-65, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 452);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(lblLoading);
            Controls.Add(pgbCarregamento);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora Ora Ora...";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgbCarregamento;
        private Label lblLoading;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
