using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaMDi
{
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            InitializeComponent();
        }

        // Cargar foto JPG
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos JPG|*.jpg;*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picPortada.Image = Image.FromFile(openFileDialog1.FileName);
                picPortada.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // Limpiar controles
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            ckbNuevo.Checked = false;

            if (picPortada.Image != null)
            {
                picPortada.Image.Dispose();
                picPortada.Image = null;
            }

            openFileDialog1.FileName = "";
        }

        // Guardar libro en la lista global
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Por favor rellena el formulario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Libro nuevoLibro = new Libro(
                txtTitulo.Text,
                txtAutor.Text,
                txtEditorial.Text,
                ckbNuevo.Checked,
                openFileDialog1.FileName
            );

            Program.ListaLibros.Add(nuevoLibro);

            MessageBox.Show("Libro guardado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnLimpiar_Click(sender, e);
        }
    }
}