namespace Calculadora
{
    partial class frmPrincipal
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
            lblResultado = new Label();
            btnPorcentagem = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnSoma = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnSubtracao = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnTres = new Button();
            btnDois = new Button();
            btnUm = new Button();
            btnApagar = new Button();
            mspMenu = new MenuStrip();
            sitemMedidas = new ToolStripMenuItem();
            mspMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.Transparent;
            lblResultado.FlatStyle = FlatStyle.Popup;
            lblResultado.Font = new Font("Simplex_IV25", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.White;
            lblResultado.Location = new Point(12, 35);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(455, 100);
            lblResultado.TabIndex = 0;
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.DodgerBlue;
            btnPorcentagem.Cursor = Cursors.Hand;
            btnPorcentagem.FlatStyle = FlatStyle.Popup;
            btnPorcentagem.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnPorcentagem.ForeColor = Color.White;
            btnPorcentagem.Location = new Point(13, 148);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(109, 94);
            btnPorcentagem.TabIndex = 4;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += Button_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.Gray;
            btnZero.BackgroundImage = Properties.Resources.pucci;
            btnZero.BackgroundImageLayout = ImageLayout.Stretch;
            btnZero.Cursor = Cursors.Hand;
            btnZero.FlatStyle = FlatStyle.Popup;
            btnZero.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnZero.ForeColor = Color.White;
            btnZero.Location = new Point(128, 148);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(109, 94);
            btnZero.TabIndex = 5;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += Button_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.DodgerBlue;
            btnVirgula.Cursor = Cursors.Hand;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(243, 148);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(109, 94);
            btnVirgula.TabIndex = 6;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += Button_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.LimeGreen;
            btnIgual.Cursor = Cursors.Hand;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(12, 546);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(340, 94);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.DodgerBlue;
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatStyle = FlatStyle.Popup;
            btnSoma.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnSoma.ForeColor = Color.White;
            btnSoma.Location = new Point(357, 447);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(109, 94);
            btnSoma.TabIndex = 11;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += Button_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.Gray;
            btnNove.BackgroundImage = Properties.Resources.johnny;
            btnNove.BackgroundImageLayout = ImageLayout.Stretch;
            btnNove.Cursor = Cursors.Hand;
            btnNove.FlatStyle = FlatStyle.Popup;
            btnNove.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnNove.ForeColor = Color.White;
            btnNove.Location = new Point(243, 448);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(109, 94);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += Button_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.Gray;
            btnOito.BackgroundImage = Properties.Resources.giorno;
            btnOito.BackgroundImageLayout = ImageLayout.Stretch;
            btnOito.Cursor = Cursors.Hand;
            btnOito.FlatStyle = FlatStyle.Popup;
            btnOito.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnOito.ForeColor = Color.White;
            btnOito.Location = new Point(128, 447);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(109, 94);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += Button_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.Gray;
            btnSete.BackgroundImage = Properties.Resources.gyro;
            btnSete.BackgroundImageLayout = ImageLayout.Stretch;
            btnSete.Cursor = Cursors.Hand;
            btnSete.FlatStyle = FlatStyle.Popup;
            btnSete.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnSete.ForeColor = Color.White;
            btnSete.Location = new Point(13, 448);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(109, 94);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += Button_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.DodgerBlue;
            btnSubtracao.Cursor = Cursors.Hand;
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnSubtracao.ForeColor = Color.White;
            btnSubtracao.Location = new Point(357, 347);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(109, 94);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += Button_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.Gray;
            btnSeis.BackgroundImage = Properties.Resources.kira;
            btnSeis.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeis.Cursor = Cursors.Hand;
            btnSeis.FlatStyle = FlatStyle.Popup;
            btnSeis.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnSeis.ForeColor = Color.White;
            btnSeis.Location = new Point(243, 347);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(109, 94);
            btnSeis.TabIndex = 14;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += Button_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.Gray;
            btnCinco.BackgroundImage = Properties.Resources.diavolo;
            btnCinco.BackgroundImageLayout = ImageLayout.Stretch;
            btnCinco.Cursor = Cursors.Hand;
            btnCinco.FlatStyle = FlatStyle.Popup;
            btnCinco.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnCinco.ForeColor = Color.White;
            btnCinco.Location = new Point(128, 347);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(109, 94);
            btnCinco.TabIndex = 13;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += Button_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.Gray;
            btnQuatro.BackgroundImage = Properties.Resources.mista;
            btnQuatro.BackgroundImageLayout = ImageLayout.Stretch;
            btnQuatro.Cursor = Cursors.Hand;
            btnQuatro.FlatStyle = FlatStyle.Popup;
            btnQuatro.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnQuatro.ForeColor = Color.White;
            btnQuatro.Location = new Point(13, 348);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(109, 94);
            btnQuatro.TabIndex = 12;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += Button_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.DodgerBlue;
            btnDivisao.Cursor = Cursors.Hand;
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(357, 148);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(109, 94);
            btnDivisao.TabIndex = 23;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += Button_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.DodgerBlue;
            btnMultiplicacao.Cursor = Cursors.Hand;
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = Color.White;
            btnMultiplicacao.Location = new Point(357, 248);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(109, 94);
            btnMultiplicacao.TabIndex = 19;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += Button_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.Gray;
            btnTres.BackgroundImage = Properties.Resources.jotaro1;
            btnTres.BackgroundImageLayout = ImageLayout.Stretch;
            btnTres.Cursor = Cursors.Hand;
            btnTres.FlatStyle = FlatStyle.Popup;
            btnTres.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnTres.ForeColor = Color.White;
            btnTres.Location = new Point(243, 248);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(109, 94);
            btnTres.TabIndex = 18;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += Button_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.Gray;
            btnDois.BackgroundImage = Properties.Resources.joseph;
            btnDois.BackgroundImageLayout = ImageLayout.Stretch;
            btnDois.Cursor = Cursors.Hand;
            btnDois.FlatStyle = FlatStyle.Popup;
            btnDois.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnDois.ForeColor = Color.White;
            btnDois.Location = new Point(128, 247);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(109, 94);
            btnDois.TabIndex = 17;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += Button_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.Gray;
            btnUm.BackgroundImage = Properties.Resources.dio1;
            btnUm.BackgroundImageLayout = ImageLayout.Stretch;
            btnUm.Cursor = Cursors.Hand;
            btnUm.FlatStyle = FlatStyle.Popup;
            btnUm.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnUm.ForeColor = Color.White;
            btnUm.Location = new Point(13, 248);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(109, 94);
            btnUm.TabIndex = 16;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += Button_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.LimeGreen;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold);
            btnApagar.ForeColor = Color.White;
            btnApagar.Location = new Point(357, 546);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(109, 94);
            btnApagar.TabIndex = 24;
            btnApagar.Text = "CLS";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // mspMenu
            // 
            mspMenu.Items.AddRange(new ToolStripItem[] { sitemMedidas });
            mspMenu.Location = new Point(0, 0);
            mspMenu.Name = "mspMenu";
            mspMenu.Size = new Size(479, 24);
            mspMenu.TabIndex = 25;
            mspMenu.Text = "menuStrip1";
            // 
            // sitemMedidas
            // 
            sitemMedidas.Name = "sitemMedidas";
            sitemMedidas.Size = new Size(64, 20);
            sitemMedidas.Text = "Medidas";
            sitemMedidas.Click += sitemMedidas_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(479, 647);
            Controls.Add(btnApagar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnSoma);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnPorcentagem);
            Controls.Add(lblResultado);
            Controls.Add(mspMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mspMenu;
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Ora Ora...";
            FormClosed += frmPrincipal_FormClosed;
            mspMenu.ResumeLayout(false);
            mspMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnPorcentagem;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnSubtracao;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnTres;
        private Button btnDois;
        private Button btnUm;
        private Button btnApagar;
        private MenuStrip mspMenu;
        private ToolStripMenuItem sitemMedidas;
    }
}