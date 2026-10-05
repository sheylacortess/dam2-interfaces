using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaMDi
{
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picPortada.Image = Image.FromFile(openFileDialog1.FileName);
            picPortada.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            ckbNuevo.Checked = false;
            picPortada.Image = null;

            openFileDialog1.FileName = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro nuevoLibro = new Libro(txtTitulo.Text, txtAutor.Text, txtEditorial.Text, openFileDialog1.FileName);

        }
    }
}
