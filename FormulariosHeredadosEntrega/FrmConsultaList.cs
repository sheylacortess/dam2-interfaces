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
    public partial class FrmConsultaList : FrmBase
    {
        public FrmConsultaList()
        {
            InitializeComponent();
        }
        private void FrmConsultaList_Load(object sender, EventArgs e)
        {
            lvClientes.SmallImageList = imageList1;
            cbxCiudad.Items.Add("Todas");

            // Rellenar lista y ciudades directamente
            foreach (Cliente c in Program.ListaClientes)
            {
                if (!cbxCiudad.Items.Contains(c.GetCiudad()))
                    cbxCiudad.Items.Add(c.GetCiudad());
            }
            cbxCiudad.SelectedIndex = 0;
            Refrescar();
        }

        private void Refrescar()
        {
            lvClientes.Items.Clear();
            string ciudad = cbxCiudad.Text;

            foreach (Cliente c in Program.ListaClientes)
            {
                if (ciudad == "Todas" || c.GetCiudad() == ciudad)
                {
                    ListViewItem item = new ListViewItem(c.GetNombre());
                    item.SubItems.Add(c.GetApellidos());
                    item.SubItems.Add(c.GetEmail());
                    item.SubItems.Add(c.GetComentario());

                    // Icono: índice 1 si es VIP, 0 si es normal
                    item.ImageIndex = c.GetVip() ? 1 : 0;
                    item.Tag = c;

                    lvClientes.Items.Add(item);
                }
            }
        }

        private void cbxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void lvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvClientes.SelectedItems.Count > 0)
            {
                Cliente c = (Cliente)lvClientes.SelectedItems[0].Tag;
                if (c != null && !string.IsNullOrEmpty(c.GetFoto()))
                    pictureBox1.Image = Image.FromFile(c.GetFoto());
                else
                    pictureBox1.Image = null;
            }
        }
    }
}
