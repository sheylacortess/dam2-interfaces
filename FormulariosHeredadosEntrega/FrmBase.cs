namespace FormulariosHeredadosEntrega
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Creamos el formulario de alta
            FrmAlta frm = new FrmAlta();
            // 2. Lo mostramos
            frm.Show();
            // 3. Ocultamos el actual
            this.Hide();
        }

        private void consultaListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaList frm = new FrmConsultaList();
            frm.Show();
            this.Hide();
        }

        private void consultaTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaTree frm = new FrmConsultaTree();
            frm.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
