namespace Calculadora
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            Random rng = new Random();

            // Randomiza o tempo de carregamento
            pgbCarregamento.Maximum = rng.Next(5, 30);

            tmrCarregamento.Enabled = true;
        }

        private void tmrCarregamento_Tick(object sender, EventArgs e)
        {
            if (pgbCarregamento.Value >= pgbCarregamento.Maximum)
            {
                tmrCarregamento.Enabled = false;

                // Fecha a tela atual
                this.Hide();

                // Abre a tela do menu
                frmMenu screen = new frmMenu();
                screen.Show();
            }

            else
            {
                pgbCarregamento.Value += 1;
            }
        }
    }
}
