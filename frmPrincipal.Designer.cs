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
            btnTrocaDeSinal = new Button();
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
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.White;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.FlatStyle = FlatStyle.Popup;
            lblResultado.Font = new Font("Simplex_IV25", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(14, 12);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(516, 133);
            lblResultado.TabIndex = 0;
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnTrocaDeSinal
            // 
            btnTrocaDeSinal.BackColor = Color.DodgerBlue;
            btnTrocaDeSinal.Cursor = Cursors.Hand;
            btnTrocaDeSinal.FlatStyle = FlatStyle.Popup;
            btnTrocaDeSinal.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnTrocaDeSinal.ForeColor = Color.White;
            btnTrocaDeSinal.Location = new Point(12, 163);
            btnTrocaDeSinal.Margin = new Padding(3, 4, 3, 4);
            btnTrocaDeSinal.Name = "btnTrocaDeSinal";
            btnTrocaDeSinal.Size = new Size(125, 125);
            btnTrocaDeSinal.TabIndex = 4;
            btnTrocaDeSinal.Text = "+/-";
            btnTrocaDeSinal.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.Gray;
            btnZero.BackgroundImage = Properties.Resources.pucci;
            btnZero.BackgroundImageLayout = ImageLayout.Stretch;
            btnZero.Cursor = Cursors.Hand;
            btnZero.FlatStyle = FlatStyle.Popup;
            btnZero.Font = new Font("Wide Latin", 19.8000011F);
            btnZero.ForeColor = Color.White;
            btnZero.Location = new Point(143, 163);
            btnZero.Margin = new Padding(3, 4, 3, 4);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(125, 125);
            btnZero.TabIndex = 5;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.DodgerBlue;
            btnVirgula.Cursor = Cursors.Hand;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(274, 163);
            btnVirgula.Margin = new Padding(3, 4, 3, 4);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(125, 125);
            btnVirgula.TabIndex = 6;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Orange;
            btnIgual.Cursor = Cursors.Hand;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(10, 694);
            btnIgual.Margin = new Padding(3, 4, 3, 4);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(389, 125);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.DodgerBlue;
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatStyle = FlatStyle.Popup;
            btnSoma.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnSoma.ForeColor = Color.White;
            btnSoma.Location = new Point(405, 561);
            btnSoma.Margin = new Padding(3, 4, 3, 4);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(125, 125);
            btnSoma.TabIndex = 11;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.Gray;
            btnNove.BackgroundImage = Properties.Resources.diavolo;
            btnNove.BackgroundImageLayout = ImageLayout.Stretch;
            btnNove.Cursor = Cursors.Hand;
            btnNove.FlatStyle = FlatStyle.Popup;
            btnNove.Font = new Font("Wide Latin", 19.8000011F);
            btnNove.ForeColor = Color.Lime;
            btnNove.Location = new Point(274, 562);
            btnNove.Margin = new Padding(3, 4, 3, 4);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(125, 125);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.Gray;
            btnOito.BackgroundImage = Properties.Resources.giorno;
            btnOito.BackgroundImageLayout = ImageLayout.Stretch;
            btnOito.Cursor = Cursors.Hand;
            btnOito.FlatStyle = FlatStyle.Popup;
            btnOito.Font = new Font("Wide Latin", 19.8000011F);
            btnOito.ForeColor = Color.FromArgb(15, 116, 245);
            btnOito.Location = new Point(143, 561);
            btnOito.Margin = new Padding(3, 4, 3, 4);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(125, 125);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.Gray;
            btnSete.BackgroundImage = Properties.Resources.gyro;
            btnSete.BackgroundImageLayout = ImageLayout.Stretch;
            btnSete.Cursor = Cursors.Hand;
            btnSete.FlatStyle = FlatStyle.Popup;
            btnSete.Font = new Font("Wide Latin", 19.8000011F);
            btnSete.ForeColor = Color.White;
            btnSete.Location = new Point(12, 562);
            btnSete.Margin = new Padding(3, 4, 3, 4);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(125, 125);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.DodgerBlue;
            btnSubtracao.Cursor = Cursors.Hand;
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnSubtracao.ForeColor = Color.White;
            btnSubtracao.Location = new Point(405, 428);
            btnSubtracao.Margin = new Padding(3, 4, 3, 4);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(125, 125);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.Gray;
            btnSeis.BackgroundImage = Properties.Resources.johnny;
            btnSeis.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeis.Cursor = Cursors.Hand;
            btnSeis.FlatStyle = FlatStyle.Popup;
            btnSeis.Font = new Font("Wide Latin", 19.8000011F);
            btnSeis.ForeColor = Color.White;
            btnSeis.Location = new Point(274, 428);
            btnSeis.Margin = new Padding(3, 4, 3, 4);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(125, 125);
            btnSeis.TabIndex = 14;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.Gray;
            btnCinco.BackgroundImage = Properties.Resources.kira;
            btnCinco.BackgroundImageLayout = ImageLayout.Stretch;
            btnCinco.Cursor = Cursors.Hand;
            btnCinco.FlatStyle = FlatStyle.Popup;
            btnCinco.Font = new Font("Wide Latin", 19.8000011F);
            btnCinco.ForeColor = Color.White;
            btnCinco.Location = new Point(143, 428);
            btnCinco.Margin = new Padding(3, 4, 3, 4);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(125, 125);
            btnCinco.TabIndex = 13;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.Gray;
            btnQuatro.BackgroundImage = Properties.Resources.mista;
            btnQuatro.BackgroundImageLayout = ImageLayout.Stretch;
            btnQuatro.Cursor = Cursors.Hand;
            btnQuatro.FlatStyle = FlatStyle.Popup;
            btnQuatro.Font = new Font("Wide Latin", 19.8000011F);
            btnQuatro.ForeColor = Color.White;
            btnQuatro.Location = new Point(12, 429);
            btnQuatro.Margin = new Padding(3, 4, 3, 4);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(125, 125);
            btnQuatro.TabIndex = 12;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.DodgerBlue;
            btnDivisao.Cursor = Cursors.Hand;
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(405, 163);
            btnDivisao.Margin = new Padding(3, 4, 3, 4);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(125, 125);
            btnDivisao.TabIndex = 23;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.DodgerBlue;
            btnMultiplicacao.Cursor = Cursors.Hand;
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = Color.White;
            btnMultiplicacao.Location = new Point(405, 296);
            btnMultiplicacao.Margin = new Padding(3, 4, 3, 4);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(125, 125);
            btnMultiplicacao.TabIndex = 19;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.Gray;
            btnTres.BackgroundImage = Properties.Resources.jotaro1;
            btnTres.BackgroundImageLayout = ImageLayout.Stretch;
            btnTres.Cursor = Cursors.Hand;
            btnTres.FlatStyle = FlatStyle.Popup;
            btnTres.Font = new Font("Wide Latin", 19.8000011F);
            btnTres.ForeColor = Color.White;
            btnTres.Location = new Point(274, 296);
            btnTres.Margin = new Padding(3, 4, 3, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(125, 125);
            btnTres.TabIndex = 18;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.Gray;
            btnDois.BackgroundImage = Properties.Resources.joseph;
            btnDois.BackgroundImageLayout = ImageLayout.Stretch;
            btnDois.Cursor = Cursors.Hand;
            btnDois.FlatStyle = FlatStyle.Popup;
            btnDois.Font = new Font("Wide Latin", 19.8000011F);
            btnDois.ForeColor = Color.FromArgb(245, 15, 89);
            btnDois.Location = new Point(143, 295);
            btnDois.Margin = new Padding(3, 4, 3, 4);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(125, 125);
            btnDois.TabIndex = 17;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.Gray;
            btnUm.BackgroundImage = Properties.Resources.dio1;
            btnUm.BackgroundImageLayout = ImageLayout.Stretch;
            btnUm.Cursor = Cursors.Hand;
            btnUm.FlatStyle = FlatStyle.Popup;
            btnUm.Font = new Font("Wide Latin", 19.8000011F);
            btnUm.ForeColor = Color.White;
            btnUm.Location = new Point(12, 296);
            btnUm.Margin = new Padding(3, 4, 3, 4);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(125, 125);
            btnUm.TabIndex = 16;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Orange;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnApagar.ForeColor = Color.White;
            btnApagar.Location = new Point(405, 694);
            btnApagar.Margin = new Padding(3, 4, 3, 4);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(125, 125);
            btnApagar.TabIndex = 24;
            btnApagar.Text = "CLS";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(547, 828);
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
            Controls.Add(btnTrocaDeSinal);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Ora Ora...";
            FormClosed += frmPrincipal_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Label lblResultado;
        private Button btnTrocaDeSinal;
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
    }
}