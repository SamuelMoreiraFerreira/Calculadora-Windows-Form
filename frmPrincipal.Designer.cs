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
            lblResultado.BackColor = Color.OliveDrab;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.FlatStyle = FlatStyle.Popup;
            lblResultado.Font = new Font("Simplex_IV25", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(12, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(358, 100);
            lblResultado.TabIndex = 0;
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnTrocaDeSinal
            // 
            btnTrocaDeSinal.BackColor = Color.DodgerBlue;
            btnTrocaDeSinal.FlatStyle = FlatStyle.Popup;
            btnTrocaDeSinal.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnTrocaDeSinal.ForeColor = Color.White;
            btnTrocaDeSinal.Location = new Point(12, 124);
            btnTrocaDeSinal.Name = "btnTrocaDeSinal";
            btnTrocaDeSinal.Size = new Size(85, 85);
            btnTrocaDeSinal.TabIndex = 4;
            btnTrocaDeSinal.Text = "+/-";
            btnTrocaDeSinal.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.Gray;
            btnZero.FlatStyle = FlatStyle.Popup;
            btnZero.Font = new Font("Courier New", 15.75F);
            btnZero.ForeColor = Color.White;
            btnZero.Location = new Point(103, 124);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(85, 85);
            btnZero.TabIndex = 5;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.DodgerBlue;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(194, 124);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(85, 85);
            btnVirgula.TabIndex = 6;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Orange;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(12, 489);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(267, 85);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.DodgerBlue;
            btnSoma.FlatStyle = FlatStyle.Popup;
            btnSoma.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnSoma.ForeColor = Color.White;
            btnSoma.Location = new Point(285, 397);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(85, 85);
            btnSoma.TabIndex = 11;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.Gray;
            btnNove.FlatStyle = FlatStyle.Popup;
            btnNove.Font = new Font("Courier New", 15.75F);
            btnNove.ForeColor = Color.White;
            btnNove.Location = new Point(194, 397);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(85, 85);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.Gray;
            btnOito.FlatStyle = FlatStyle.Popup;
            btnOito.Font = new Font("Courier New", 15.75F);
            btnOito.ForeColor = Color.White;
            btnOito.Location = new Point(103, 397);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(85, 85);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.Gray;
            btnSete.FlatStyle = FlatStyle.Popup;
            btnSete.Font = new Font("Courier New", 15.75F);
            btnSete.ForeColor = Color.White;
            btnSete.Location = new Point(12, 397);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(85, 85);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.DodgerBlue;
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnSubtracao.ForeColor = Color.White;
            btnSubtracao.Location = new Point(285, 306);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(85, 85);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.Gray;
            btnSeis.FlatStyle = FlatStyle.Popup;
            btnSeis.Font = new Font("Courier New", 15.75F);
            btnSeis.ForeColor = Color.White;
            btnSeis.Location = new Point(194, 306);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(85, 85);
            btnSeis.TabIndex = 14;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.Gray;
            btnCinco.FlatStyle = FlatStyle.Popup;
            btnCinco.Font = new Font("Courier New", 15.75F);
            btnCinco.ForeColor = Color.White;
            btnCinco.Location = new Point(103, 306);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(85, 85);
            btnCinco.TabIndex = 13;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.Gray;
            btnQuatro.FlatStyle = FlatStyle.Popup;
            btnQuatro.Font = new Font("Courier New", 15.75F);
            btnQuatro.ForeColor = Color.White;
            btnQuatro.Location = new Point(12, 306);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(85, 85);
            btnQuatro.TabIndex = 12;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.DodgerBlue;
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(285, 124);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(85, 85);
            btnDivisao.TabIndex = 23;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.DodgerBlue;
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = Color.White;
            btnMultiplicacao.Location = new Point(285, 215);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(85, 85);
            btnMultiplicacao.TabIndex = 19;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.Gray;
            btnTres.FlatStyle = FlatStyle.Popup;
            btnTres.Font = new Font("Courier New", 15.75F);
            btnTres.ForeColor = Color.White;
            btnTres.Location = new Point(194, 215);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(85, 85);
            btnTres.TabIndex = 18;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.Gray;
            btnDois.FlatStyle = FlatStyle.Popup;
            btnDois.Font = new Font("Courier New", 15.75F);
            btnDois.ForeColor = Color.White;
            btnDois.Location = new Point(103, 215);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(85, 85);
            btnDois.TabIndex = 17;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.Gray;
            btnUm.FlatStyle = FlatStyle.Popup;
            btnUm.Font = new Font("Courier New", 15.75F);
            btnUm.ForeColor = Color.White;
            btnUm.Location = new Point(12, 215);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(85, 85);
            btnUm.TabIndex = 16;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Orange;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnApagar.ForeColor = Color.White;
            btnApagar.Location = new Point(285, 489);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(85, 85);
            btnApagar.TabIndex = 24;
            btnApagar.Text = "CLS";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(384, 590);
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
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Ora Ora...";
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