namespace FormulariosHeredadosEntrega
{
    partial class FrmConsultaList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cbxCiudad = new ComboBox();
            cbxVista = new ComboBox();
            lvClientes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            lblCiudad = new Label();
            lblVista = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbxCiudad
            // 
            cbxCiudad.FormattingEnabled = true;
            cbxCiudad.Location = new Point(277, 123);
            cbxCiudad.Name = "cbxCiudad";
            cbxCiudad.Size = new Size(240, 23);
            cbxCiudad.TabIndex = 1;
            cbxCiudad.SelectedIndexChanged += cbxCiudad_SelectedIndexChanged;
            // 
            // cbxVista
            // 
            cbxVista.FormattingEnabled = true;
            cbxVista.Location = new Point(556, 123);
            cbxVista.Name = "cbxVista";
            cbxVista.Size = new Size(164, 23);
            cbxVista.TabIndex = 2;
            // 
            // lvClientes
            // 
            lvClientes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvClientes.Location = new Point(277, 178);
            lvClientes.Name = "lvClientes";
            lvClientes.Size = new Size(443, 180);
            lvClientes.TabIndex = 3;
            lvClientes.UseCompatibleStateImageBehavior = false;
            lvClientes.View = View.Details;
            lvClientes.SelectedIndexChanged += lvClientes_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Apellidos";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "email";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "comentario";
            columnHeader4.Width = 120;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(55, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 277);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(277, 81);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(45, 15);
            lblCiudad.TabIndex = 5;
            lblCiudad.Text = "Ciudad";
            // 
            // lblVista
            // 
            lblVista.AutoSize = true;
            lblVista.Location = new Point(556, 81);
            lblVista.Name = "lblVista";
            lblVista.Size = new Size(32, 15);
            lblVista.TabIndex = 6;
            lblVista.Text = "Vista";
            // 
            // FrmConsultaList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVista);
            Controls.Add(lblCiudad);
            Controls.Add(pictureBox1);
            Controls.Add(lvClientes);
            Controls.Add(cbxVista);
            Controls.Add(cbxCiudad);
            Name = "FrmConsultaList";
            Text = "FrmConsultaList";
            Load += FrmConsultaList_Load;
            Controls.SetChildIndex(cbxCiudad, 0);
            Controls.SetChildIndex(cbxVista, 0);
            Controls.SetChildIndex(lvClientes, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(lblCiudad, 0);
            Controls.SetChildIndex(lblVista, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxCiudad;
        private ComboBox cbxVista;
        private ListView lvClientes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label lblCiudad;
        private Label lblVista;
    }
}