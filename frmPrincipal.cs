using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {

        readonly DataTable tabela = new DataTable();
        string equacao = "";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            this.equacao = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            this.equacao = this.tabela.Compute(this.equacao, null).ToString()!;

            lblResultado.Text = this.equacao;
        }

        private void UpdateEquacao(string txt)
        {
            this.equacao += txt;

            lblResultado.Text = this.equacao;
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            UpdateEquacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            UpdateEquacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            UpdateEquacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            UpdateEquacao("/");
        }

        private void btnTrocaDeSinal_Click(object sender, EventArgs e)
        {
            UpdateEquacao("* -1");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            UpdateEquacao("0");
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fecha todos os processos do Aplicativo
            Application.Exit();
        }
    }
}
