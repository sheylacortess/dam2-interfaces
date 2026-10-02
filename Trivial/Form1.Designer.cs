namespace Trivial
{
    partial class FrmCapitales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            partidaToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nombreCapitalesToolStripMenuItem = new ToolStripMenuItem();
            nombrePaísesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            multiplesOpcionesToolStripMenuItem = new ToolStripMenuItem();
            escribirRespuestaToolStripMenuItem = new ToolStripMenuItem();
            TxtRespuesta = new TextBox();
            LblPais = new Label();
            btnOpcion1 = new Button();
            btnOpcion2 = new Button();
            btnOpcion3 = new Button();
            btnOpcion4 = new Button();
            lblPorcentaje = new Label();
            lblSiguiente = new Label();
            lblPregunta = new Label();
            lblCapital = new Label();
            lblFeedback = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { partidaToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(330, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // partidaToolStripMenuItem
            // 
            partidaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            partidaToolStripMenuItem.Size = new Size(56, 20);
            partidaToolStripMenuItem.Text = "Partida";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(180, 22);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += nuevaToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreCapitalesToolStripMenuItem, nombrePaísesToolStripMenuItem, toolStripSeparator2, multiplesOpcionesToolStripMenuItem, escribirRespuestaToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nombreCapitalesToolStripMenuItem
            // 
            nombreCapitalesToolStripMenuItem.Name = "nombreCapitalesToolStripMenuItem";
            nombreCapitalesToolStripMenuItem.Size = new Size(176, 22);
            nombreCapitalesToolStripMenuItem.Text = "Nombre Capitales";
            // 
            // nombrePaísesToolStripMenuItem
            // 
            nombrePaísesToolStripMenuItem.Name = "nombrePaísesToolStripMenuItem";
            nombrePaísesToolStripMenuItem.Size = new Size(176, 22);
            nombrePaísesToolStripMenuItem.Text = "Nombre Países";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(173, 6);
            // 
            // multiplesOpcionesToolStripMenuItem
            // 
            multiplesOpcionesToolStripMenuItem.Name = "multiplesOpcionesToolStripMenuItem";
            multiplesOpcionesToolStripMenuItem.Size = new Size(176, 22);
            multiplesOpcionesToolStripMenuItem.Text = "Multiples Opciones";
            multiplesOpcionesToolStripMenuItem.Click += multiplesOpcionesToolStripMenuItem_Click;
            // 
            // escribirRespuestaToolStripMenuItem
            // 
            escribirRespuestaToolStripMenuItem.Name = "escribirRespuestaToolStripMenuItem";
            escribirRespuestaToolStripMenuItem.Size = new Size(176, 22);
            escribirRespuestaToolStripMenuItem.Text = "Escribir Respuesta";
            escribirRespuestaToolStripMenuItem.Click += escribirRespuestaToolStripMenuItem_Click;
            // 
            // TxtRespuesta
            // 
            TxtRespuesta.Font = new Font("Microsoft Sans Serif", 20F);
            TxtRespuesta.Location = new Point(21, 170);
            TxtRespuesta.Name = "TxtRespuesta";
            TxtRespuesta.Size = new Size(250, 38);
            TxtRespuesta.TabIndex = 1;
            TxtRespuesta.KeyDown += TxtRespuesta_KeyDown;
            // 
            // LblPais
            // 
            LblPais.AutoSize = true;
            LblPais.Font = new Font("Segoe UI", 10F);
            LblPais.Location = new Point(21, 39);
            LblPais.Name = "LblPais";
            LblPais.Size = new Size(33, 19);
            LblPais.TabIndex = 2;
            LblPais.Text = "Pais";
            // 
            // btnOpcion1
            // 
            btnOpcion1.Location = new Point(21, 180);
            btnOpcion1.Name = "btnOpcion1";
            btnOpcion1.Size = new Size(250, 30);
            btnOpcion1.TabIndex = 3;
            btnOpcion1.UseVisualStyleBackColor = true;
            btnOpcion1.Click += btnOpcion_Click;
            // 
            // btnOpcion2
            // 
            btnOpcion2.Location = new Point(21, 214);
            btnOpcion2.Name = "btnOpcion2";
            btnOpcion2.Size = new Size(250, 30);
            btnOpcion2.TabIndex = 4;
            btnOpcion2.UseVisualStyleBackColor = true;
            btnOpcion2.Click += btnOpcion_Click;
            // 
            // btnOpcion3
            // 
            btnOpcion3.Location = new Point(21, 250);
            btnOpcion3.Name = "btnOpcion3";
            btnOpcion3.Size = new Size(250, 30);
            btnOpcion3.TabIndex = 5;
            btnOpcion3.UseVisualStyleBackColor = true;
            btnOpcion3.Click += btnOpcion_Click;
            // 
            // btnOpcion4
            // 
            btnOpcion4.Location = new Point(21, 286);
            btnOpcion4.Name = "btnOpcion4";
            btnOpcion4.Size = new Size(250, 30);
            btnOpcion4.TabIndex = 6;
            btnOpcion4.UseVisualStyleBackColor = true;
            btnOpcion4.Click += btnOpcion_Click;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.BackColor = Color.RosyBrown;
            lblPorcentaje.ForeColor = SystemColors.ControlLightLight;
            lblPorcentaje.Location = new Point(236, 328);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(35, 30);
            lblPorcentaje.TabIndex = 7;
            // 
            // lblSiguiente
            // 
            lblSiguiente.BackColor = Color.LightGray;
            lblSiguiente.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSiguiente.Location = new Point(40, 328);
            lblSiguiente.Name = "lblSiguiente";
            lblSiguiente.Size = new Size(113, 38);
            lblSiguiente.TabIndex = 8;
            lblSiguiente.Text = "Siguiente";
            lblSiguiente.Click += lblSiguiente_Click;
            // 
            // lblPregunta
            // 
            lblPregunta.BackColor = SystemColors.ActiveBorder;
            lblPregunta.Location = new Point(21, 78);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(250, 30);
            lblPregunta.TabIndex = 9;
            // 
            // lblCapital
            // 
            lblCapital.AutoSize = true;
            lblCapital.Font = new Font("Segoe UI", 10F);
            lblCapital.Location = new Point(21, 137);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(51, 19);
            lblCapital.TabIndex = 10;
            lblCapital.Text = "Capital";
            // 
            // lblFeedback
            // 
            lblFeedback.BackColor = Color.MidnightBlue;
            lblFeedback.ForeColor = SystemColors.ControlLightLight;
            lblFeedback.Location = new Point(151, 128);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(120, 28);
            lblFeedback.TabIndex = 11;
            // 
            // FrmCapitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(330, 420);
            Controls.Add(lblFeedback);
            Controls.Add(lblCapital);
            Controls.Add(lblPregunta);
            Controls.Add(lblSiguiente);
            Controls.Add(lblPorcentaje);
            Controls.Add(btnOpcion4);
            Controls.Add(btnOpcion3);
            Controls.Add(btnOpcion2);
            Controls.Add(btnOpcion1);
            Controls.Add(LblPais);
            Controls.Add(TxtRespuesta);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmCapitales";
            Text = "Capitales del Mundo";
            Load += FrmCapitales_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem partidaToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem nombreCapitalesToolStripMenuItem;
        private ToolStripMenuItem nombrePaísesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem multiplesOpcionesToolStripMenuItem;
        private ToolStripMenuItem escribirRespuestaToolStripMenuItem;
        private TextBox TxtRespuesta;
        private Label LblPais;
        private Button btnOpcion1;
        private Button btnOpcion2;
        private Button btnOpcion3;
        private Button btnOpcion4;
        private Label lblPorcentaje;
        private Label lblSiguiente;
        private Label lblPregunta;
        private Label lblCapital;
        private Label lblFeedback;
    }
}
