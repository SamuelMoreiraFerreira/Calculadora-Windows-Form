namespace Calculadora
{
    public partial class frmLoading : Form
    {

        public int maxDelay = 30;
        public int minDelay = 5;

        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            Random rng = new Random();

            // Randomiza o tempo de carregamento
            pgbCarregamento.Maximum = rng.Next(this.minDelay, this.maxDelay);

            tmrCarregamento.Enabled = true;
        }

        private void tmrCarregamento_Tick(object sender, EventArgs e)
        {
            if (pgbCarregamento.Value >= pgbCarregamento.Maximum)
            {
                tmrCarregamento.Enabled = false;

                // Fecha a tela atual
                this.Close();
            }

            else
            {
                pgbCarregamento.Value += 1;
            }
        }

        private void frmLoading_KeyDown(object sender, KeyEventArgs e)
        {
            // Easter Egg para pular o loading

            if (e.KeyCode == Keys.Space)
            {
                pgbCarregamento.Value = pgbCarregamento.Maximum;
            }
        }
    }
}
