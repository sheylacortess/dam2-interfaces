using System;
using System.Windows.Forms;

namespace BibliotecaMDi
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MnuAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = null;

            // 1. Buscamos si el formulario de alta ya está abierto entre los hijos MDI
            foreach (Form hijo in MdiChildren)
            {
                if (hijo is FrmAlta)
                {
                    frmAlta = (FrmAlta)hijo;
                    break;
                }
            }

            // 2. Si no existe, lo creamos y lo asignamos como hijo MDI
            if (frmAlta == null)
            {
                frmAlta = new FrmAlta();
                frmAlta.MdiParent = this;
                frmAlta.Dock = DockStyle.Fill; // Opcional: hace que ocupe todo el espacio interior
            }

            // 3. Lo mostramos y lo traemos al frente
            frmAlta.Show();
            frmAlta.BringToFront();
        }

        private void MnuConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta frmConsulta = null;

            // 1. Buscamos si el formulario de consulta ya está abierto
            foreach (Form hijo in MdiChildren)
            {
                if (hijo is FrmConsulta)
                {
                    frmConsulta = (FrmConsulta)hijo;
                    break;
                }
            }

            // 2. Si no existe, lo creamos
            if (frmConsulta == null)
            {
                frmConsulta = new FrmConsulta();
                frmConsulta.MdiParent = this;
                frmConsulta.Dock = DockStyle.Fill;
            }

            // 3. Lo mostramos
            frmConsulta.Show();
            frmConsulta.BringToFront();
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