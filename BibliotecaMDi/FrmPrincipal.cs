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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                MessageBox.Show(f.GetType().ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
