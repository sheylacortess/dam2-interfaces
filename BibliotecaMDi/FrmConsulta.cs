using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaMDi
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        // Al abrir la pantalla, si está marcado el radiobutton de Autor, carga los datos
        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            if (rbAutor.Checked == true)
            {
                CargarDatos(true);
            }
        }

        // Al volver a la ventana, refresca la lista por si se añadieron libros nuevos en Alta
        private void FrmConsulta_Activated(object sender, EventArgs e)
        {
            if (rbAutor.Checked == true)
            {
                CargarDatos(true);
            }
            else if (rbEditorial.Checked == true)
            {
                CargarDatos(false);
            }
        }

        // Evento cuando se pulsa Autor
        private void rbAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutor.Checked == true)
            {
                CargarDatos(true);
            }
        }

        // Evento cuando se pulsa Editorial
        private void rbEditorial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEditorial.Checked == true)
            {
                CargarDatos(false);
            }
        }

        // Rellenar las ListBox desde la lista global
        private void CargarDatos(bool esAutor)
        {
            lbxTitulo.Items.Clear();
            lbxAutorEditorial.Items.Clear();
            pbxPortada.Image = null;

            for (int i = 0; i < Program.ListaLibros.Count; i++)
            {
                Libro l = Program.ListaLibros[i];
                lbxTitulo.Items.Add(l.getTitulo());

                if (esAutor == true)
                {
                    lbxAutorEditorial.Items.Add(l.getAutor());
                }
                else
                {
                    lbxAutorEditorial.Items.Add(l.getEditorial());
                }
            }
        }

        // Doble clic en el título para mostrar la portada
        private void lbxTitulo_DoubleClick(object sender, EventArgs e)
        {
            int posicion = lbxTitulo.SelectedIndex;

            if (posicion >= 0)
            {
                lbxAutorEditorial.SelectedIndex = posicion;
                string foto = Program.ListaLibros[posicion].getFoto();

                if (foto != "")
                {
                    pbxPortada.Image = Image.FromFile(foto);
                    pbxPortada.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}