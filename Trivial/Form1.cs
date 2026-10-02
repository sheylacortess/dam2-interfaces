namespace Trivial
{
    public partial class FrmCapitales : Form
    {
        private bool esModoMultiple = true;
        int indiceActual = 0;
        string respuestaSeleccionada = "";
        int preguntasAcertadas = 0;
        int preguntasHechas = 0;
        int MAXpreguntas = 10;


        String[] paises = { "España", "Francia", "Portugal", "Alemania", "Noruega", "Peru", "Colombia" };
        String[] capitales = { "Madrid", "Paris", "Lisboa", "Berlin", "Oslo", "Lima", "Bogota" };

        public FrmCapitales()
        {
            InitializeComponent();
        }

        private void FrmCapitales_Load(object sender, EventArgs e)
        {
            CambiarModoJuego();
            ActualizarPorcentaje();
            CargarNuevaPregunta();
        }

        private void CambiarModoJuego()
        {
            if (esModoMultiple)
            {
                btnOpcion1.Visible = true;
                btnOpcion2.Visible = true;
                btnOpcion3.Visible = true;
                btnOpcion4.Visible = true;

                TxtRespuesta.Visible = false;
            }
            else
            {
                btnOpcion1.Visible = false;
                btnOpcion2.Visible = false;
                btnOpcion3.Visible = false;
                btnOpcion4.Visible = false;

                TxtRespuesta.Visible = true;
                TxtRespuesta.Text = "";
            }
        }

        private void multiplesOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esModoMultiple = true;
            CambiarModoJuego();
            CargarNuevaPregunta();
        }

        private void escribirRespuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esModoMultiple = false;
            CambiarModoJuego();
            CargarNuevaPregunta();

        }

        private void CargarNuevaPregunta()
        {

            Random rand = new Random();
            indiceActual = rand.Next(0, paises.Length); // elige un pais al azar entre la posicion 0 y el largo del array
            lblPregunta.Text = paises[indiceActual]; //

            if (esModoMultiple)
            {

                int posicionCorrecta = rand.Next(0, 4);
                Button[] botones = [btnOpcion1, btnOpcion2, btnOpcion3, btnOpcion4];
                string CapitalCorrecta = capitales[indiceActual];
                botones[posicionCorrecta].Text = CapitalCorrecta;

                for (int i = 0; i < botones.Length; i++)
                {
                    if (i != posicionCorrecta)
                    {
                        string capitalFalsa = "";
                        do
                        {
                            int indiceFalso = rand.Next(0, capitales.Length);
                            capitalFalsa = capitales[indiceFalso];
                        } while (capitalFalsa == CapitalCorrecta);
                        botones[i].Text = capitalFalsa;
                    }
                }

            }
            else
            {
                TxtRespuesta.Clear(); //limpia la caja de texto si esta en modo escribir
            }
        }

        private void ActualizarPorcentaje()
        {
            if (preguntasHechas == 0)
            {
                lblPorcentaje.Text = "0%";
            }
            else
            {
                int porcentaje = (int)((double)preguntasAcertadas / preguntasHechas * 100);
                lblPorcentaje.Text = porcentaje + "%";
            }
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            string respuestaUsuario = "";

            if (esModoMultiple)
            {
                if (string.IsNullOrEmpty(respuestaSeleccionada))
                {
                    MessageBox.Show("Por favor selecciona una respuesta");
                    return;
                }
                respuestaUsuario = respuestaSeleccionada;
            }
            else
            {
                respuestaUsuario = TxtRespuesta.Text.Trim();
                if (string.IsNullOrEmpty(respuestaUsuario))
                {
                    MessageBox.Show("Por favor escribe una capital");
                    return;
                }
            }

            preguntasHechas++;

            if (string.Equals(respuestaUsuario, capitales[indiceActual], StringComparison.OrdinalIgnoreCase))
            {
                preguntasAcertadas++;
                lblFeedback.Text = "Correcto!";
            }
            else
            {
                lblFeedback.Text = "Incorrecto!";
            }

            ActualizarPorcentaje();
            respuestaSeleccionada = "";

            if (preguntasHechas >= MAXpreguntas)
            {
                MessageBox.Show("¡Final de la partida! Has acertado " + preguntasAcertadas + " / " + MAXpreguntas);

            }
            else
            {
                CargarNuevaPregunta();
            }
        }


        private void btnOpcion_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            respuestaSeleccionada = botonPulsado.Text;
        }

        private void TxtRespuesta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblSiguiente_Click(sender, e);
            }
        }
        private void ReiniciarPartida()
        {
            preguntasAcertadas = 0;
            preguntasHechas = 0;
            lblFeedback.Text = "";
            ActualizarPorcentaje();
            CargarNuevaPregunta();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReiniciarPartida();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
