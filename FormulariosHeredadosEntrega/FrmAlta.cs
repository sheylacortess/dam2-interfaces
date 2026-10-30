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
    public partial class FrmAlta : FrmBase
    {
        public FrmAlta()
        {
            InitializeComponent();
        }
        //para cargar una foto al pichar en el picturebox
        private void picFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos JPG|*.jpg;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        // Botón Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCiudad.Clear();
            txtEmail.Clear();
            txtComentario.Clear();
            chkVip.Checked = false;
            picFoto.Image = null;
            openFileDialog1.FileName = "";
        }

        // Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear el objeto con los datos y añadirlo a la lista global
            Cliente c = new Cliente(
                txtNombre.Text,
                txtApellidos.Text,
                txtCiudad.Text,
                txtEmail.Text,
                txtComentario.Text,
                chkVip.Checked,
                openFileDialog1.FileName
            );

            Program.ListaClientes.Add(c);

            // Añadir el nombre al ListBox de la izquierda
            lbxAlta.Items.Add(c.GetNombre() + " " + c.GetApellidos());

            MessageBox.Show("Cliente guardado");
            btnNuevo_Click(sender, e);
        }

        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            int pos = lbxAlta.SelectedIndex;
            if (pos >= 0)
            {
                Program.ListaClientes.RemoveAt(pos);
                lbxAlta.Items.RemoveAt(pos);
                btnNuevo_Click(sender, e);
            }
        }
    }
}
