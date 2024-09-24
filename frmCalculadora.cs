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
    public partial class frmCalculadora : Form
    {

        readonly DataTable table = new DataTable();
        readonly Dictionary<string, string> map = new Dictionary<string, string>()
        {
            { "btnZero", "0" },
            { "btnUm", "1" },
            { "btnDois", "2" },
            { "btnTres", "3" },
            { "btnQuatro", "4" },
            { "btnCinco", "5" },
            { "btnSeis", "6" },
            { "btnSete", "7" },
            { "btnOito", "8" },
            { "btnNove", "9" },
            { "btnSoma", "+" },
            { "btnSubtracao", "-" },
            { "btnDivisao", "/" },
            { "btnMultiplicacao", "*" },
            { "btnVirgula", "." },
            { "btnPorcentagem", "/100" },
        };

        string equacao = "";

        public frmCalculadora()
        {
            InitializeComponent();
        }
        
        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.equacao = "";

            lblResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                this.equacao = this.table.Compute(this.equacao, null).ToString()!;
            }

            // Em caso de erro o resultado será alterado para 0 a fim de evitar crash
            catch
            {
                this.equacao = "0";
            }

            lblResultado.Text = this.equacao;
        }

        private void UpdateEquacao(string txt)
        {
            this.equacao += txt;

            lblResultado.Text = this.equacao;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Usando o operador 'as' para evitar crash na conversão
            Button? btn = sender as Button;

            if (btn != null)
            {
                // Evitando crash caso o botão não estiver mapeado (KeyNotFoundException)
                if (this.map.ContainsKey(btn.Name))
                {
                    this.UpdateEquacao(this.map[btn.Name]);
                }
            }
        }
    }
}
