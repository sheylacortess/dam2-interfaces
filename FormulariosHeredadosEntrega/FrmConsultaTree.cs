using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosHeredadosEntrega
{
    public partial class FrmConsultaTree : FrmBase
    {
        public FrmConsultaTree()
        {
            InitializeComponent();
        }

        private void FrmConsultaTree_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;

            foreach (Cliente c in Program.ListaClientes)
            {
                string ciudad = string.IsNullOrEmpty(c.GetCiudad()) ? "Otros" : c.GetCiudad();

                // Buscar o crear nodo de ciudad
                TreeNode nodoCiudad = null;
                foreach (TreeNode n in treeView1.Nodes)
                    if (n.Text == ciudad) nodoCiudad = n;

                if (nodoCiudad == null)
                {
                    nodoCiudad = new TreeNode(ciudad);
                    treeView1.Nodes.Add(nodoCiudad);
                }

                // Crear nodo de cliente
                TreeNode nodoCli = new TreeNode(c.GetNombre() + " " + c.GetApellidos());
                nodoCli.ImageIndex = c.GetVip() ? 1 : 0;
                nodoCli.SelectedImageIndex = nodoCli.ImageIndex;
                nodoCli.Tag = c;

                nodoCiudad.Nodes.Add(nodoCli);
            }
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Cliente c)
            {
                txtNombre.Text = c.GetNombre();
                txtApellidos.Text = c.GetApellidos();
                txtCiudad.Text = c.GetCiudad();
                txtEmail1.Text = c.GetEmail();
                txtComentario.Text = c.GetComentario();

                pictureBox1.Image = !string.IsNullOrEmpty(c.GetFoto()) ? Image.FromFile(c.GetFoto()) : null;
            }
        }
    }
}
