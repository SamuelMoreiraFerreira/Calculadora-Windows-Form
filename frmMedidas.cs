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
    public partial class frmMedidas : Form
    {
        public frmMedidas()
        {
            InitializeComponent();
        }

        private void frmMedidas_Load(object sender, EventArgs e)
        {
            // Esconde a tela atual
            this.Hide();

            frmLoading splash = new frmLoading();
            splash.maxDelay = 15;

            // Espera o loading acabar
            splash.ShowDialog();

            // Mostra a tela atual
            this.Show();
        }
    }
}
