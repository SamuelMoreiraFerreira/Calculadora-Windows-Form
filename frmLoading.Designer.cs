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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            pgbCarregamento = new ProgressBar();
            lblLoading = new Label();
            pbxDio = new PictureBox();
            pbxJotaro = new PictureBox();
            tmrCarregamento = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxDio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxJotaro).BeginInit();
            SuspendLayout();
            // 
            // pgbCarregamento
            // 
            pgbCarregamento.Location = new Point(12, 390);
            pgbCarregamento.Name = "pgbCarregamento";
            pgbCarregamento.Size = new Size(360, 43);
            pgbCarregamento.Style = ProgressBarStyle.Continuous;
            pgbCarregamento.TabIndex = 0;
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
            // pbxDio
            // 
            pbxDio.BackColor = Color.Transparent;
            pbxDio.BackgroundImage = Properties.Resources.dio;
            pbxDio.BackgroundImageLayout = ImageLayout.Stretch;
            pbxDio.Location = new Point(190, 12);
            pbxDio.Name = "pbxDio";
            pbxDio.Size = new Size(274, 452);
            pbxDio.TabIndex = 2;
            pbxDio.TabStop = false;
            // 
            // pbxJotaro
            // 
            pbxJotaro.BackColor = Color.Transparent;
            pbxJotaro.BackgroundImage = Properties.Resources.jotaro;
            pbxJotaro.BackgroundImageLayout = ImageLayout.Stretch;
            pbxJotaro.Location = new Point(-65, 12);
            pbxJotaro.Name = "pbxJotaro";
            pbxJotaro.Size = new Size(249, 452);
            pbxJotaro.TabIndex = 3;
            pbxJotaro.TabStop = false;
            // 
            // tmrCarregamento
            // 
            tmrCarregamento.Enabled = true;
            tmrCarregamento.Interval = 1000;
            tmrCarregamento.Tick += tmrCarregamento_Tick;
            // 
            // frmLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(lblLoading);
            Controls.Add(pgbCarregamento);
            Controls.Add(pbxDio);
            Controls.Add(pbxJotaro);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Ora Ora...";
            Load += frmLoading_Load;
            KeyDown += frmLoading_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbxDio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxJotaro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgbCarregamento;
        private Label lblLoading;
        private PictureBox pbxDio;
        private PictureBox pbxJotaro;
        private System.Windows.Forms.Timer tmrCarregamento;
    }
}
