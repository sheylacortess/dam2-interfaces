namespace BibliotecaMDi
{
    public partial class FrmPrincipal : Form
    {
        private FrmAlta frmAlta;
        private FrmConsulta frmConsulta;
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void MnuAlta_Click(object sender, EventArgs e)
        {
            FrmAlta f = new FrmAlta();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta f = new FrmConsulta();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
