        namespace BibliotecaMDi
{
    partial class FrmPrincipal
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
        /// 
        private void InitializeComponent()
        {
            MnuPrincipal = new MenuStrip();
            MnuFichero = new ToolStripMenuItem();
            MnuAlta = new ToolStripMenuItem();
            MnuConsulta = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MnuSalir = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            MnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // MnuPrincipal
            // 
            MnuPrincipal.Items.AddRange(new ToolStripItem[] { MnuFichero });
            MnuPrincipal.Location = new Point(0, 0);
            MnuPrincipal.Name = "MnuPrincipal";
            MnuPrincipal.Size = new Size(800, 24);
            MnuPrincipal.TabIndex = 1;
            MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuFichero
            // 
            MnuFichero.DropDownItems.AddRange(new ToolStripItem[] { MnuAlta, MnuConsulta, toolStripSeparator1, MnuSalir });
            MnuFichero.Name = "MnuFichero";
            MnuFichero.Size = new Size(58, 20);
            MnuFichero.Text = "Fichero";
            // 
            // MnuAlta
            // 
            MnuAlta.Name = "MnuAlta";
            MnuAlta.ShortcutKeys = Keys.Control | Keys.A;
            MnuAlta.Size = new Size(163, 22);
            MnuAlta.Text = "Alta";
            MnuAlta.Click += MnuAlta_Click;
            // 
            // MnuConsulta
            // 
            MnuConsulta.Name = "MnuConsulta";
            MnuConsulta.ShortcutKeys = Keys.Control | Keys.C;
            MnuConsulta.Size = new Size(163, 22);
            MnuConsulta.Text = "Consulta";
            MnuConsulta.Click += MnuConsulta_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(160, 6);
            // 
            // MnuSalir
            // 
            MnuSalir.Name = "MnuSalir";
            MnuSalir.ShortcutKeys = Keys.Control | Keys.S;
            MnuSalir.Size = new Size(163, 22);
            MnuSalir.Text = "Salir";
            MnuSalir.Click += MnuSalir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MnuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = MnuPrincipal;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            MnuPrincipal.ResumeLayout(false);
            MnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MnuPrincipal;
        private ToolStripMenuItem MnuFichero;
        private ToolStripMenuItem MnuAlta;
        private ToolStripMenuItem MnuConsulta;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MnuSalir;
        private OpenFileDialog openFileDialog1;
    }
}
