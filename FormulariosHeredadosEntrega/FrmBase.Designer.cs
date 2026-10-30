namespace FormulariosHeredadosEntrega
{
    partial class FrmBase
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            altaToolStripMenuItem = new ToolStripMenuItem();
            consultaListToolStripMenuItem = new ToolStripMenuItem();
            consultaTreeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { altaToolStripMenuItem, consultaListToolStripMenuItem, consultaTreeToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(40, 20);
            altaToolStripMenuItem.Text = "Alta";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // consultaListToolStripMenuItem
            // 
            consultaListToolStripMenuItem.Name = "consultaListToolStripMenuItem";
            consultaListToolStripMenuItem.Size = new Size(87, 20);
            consultaListToolStripMenuItem.Text = "Consulta List";
            consultaListToolStripMenuItem.Click += consultaListToolStripMenuItem_Click;
            // 
            // consultaTreeToolStripMenuItem
            // 
            consultaTreeToolStripMenuItem.Name = "consultaTreeToolStripMenuItem";
            consultaTreeToolStripMenuItem.Size = new Size(91, 20);
            consultaTreeToolStripMenuItem.Text = "Consulta Tree";
            consultaTreeToolStripMenuItem.Click += consultaTreeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmBase";
            Text = "FrmBase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem consultaListToolStripMenuItem;
        private ToolStripMenuItem consultaTreeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ImageList imageList1;
    }
}
