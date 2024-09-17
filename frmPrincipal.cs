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
            lblResultado.Text = Math.Equals();
        }
    }
}
