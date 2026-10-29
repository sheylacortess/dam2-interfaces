namespace FormulariosHeredadosEntrega
{
    partial class FrmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            picFoto = new PictureBox();
            imageList1 = new ImageList(components);
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtCiudad = new TextBox();
            txtEmail = new TextBox();
            txtComentario = new TextBox();
            chkVip = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            lbxAlta = new ListBox();
            btnNuevo = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblCiudad = new Label();
            lblEmail = new Label();
            lblComentario = new Label();
            lblVip = new Label();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // picFoto
            // 
            picFoto.Location = new Point(438, 85);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(212, 96);
            picFoto.TabIndex = 1;
            picFoto.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "borrar.png");
            imageList1.Images.SetKeyName(1, "casa.png");
            imageList1.Images.SetKeyName(2, "estrella.png");
            imageList1.Images.SetKeyName(3, "save.png");
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(439, 187);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(439, 216);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(211, 23);
            txtApellidos.TabIndex = 6;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(439, 245);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(211, 23);
            txtCiudad.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(439, 274);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(439, 303);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(211, 54);
            txtComentario.TabIndex = 9;
            // 
            // chkVip
            // 
            chkVip.AutoSize = true;
            chkVip.Location = new Point(439, 376);
            chkVip.Name = "chkVip";
            chkVip.Size = new Size(15, 14);
            chkVip.TabIndex = 10;
            chkVip.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(34, 34);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnGuardar, toolStripButton5 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 56);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // lbxAlta
            // 
            lbxAlta.FormattingEnabled = true;
            lbxAlta.ItemHeight = 15;
            lbxAlta.Location = new Point(34, 139);
            lbxAlta.Name = "lbxAlta";
            lbxAlta.Size = new Size(240, 184);
            lbxAlta.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.TopCenter;
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(46, 53);
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(53, 53);
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(43, 53);
            toolStripButton5.Text = "Borrar";
            toolStripButton5.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(310, 192);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(310, 224);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 14;
            lblApellidos.Text = "Apellidos";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(310, 253);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(45, 15);
            lblCiudad.TabIndex = 15;
            lblCiudad.Text = "Ciudad";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(310, 277);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "e-mail";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(310, 308);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(70, 15);
            lblComentario.TabIndex = 17;
            lblComentario.Text = "Comentario";
            // 
            // lblVip
            // 
            lblVip.AutoSize = true;
            lblVip.Location = new Point(315, 376);
            lblVip.Name = "lblVip";
            lblVip.Size = new Size(24, 15);
            lblVip.TabIndex = 18;
            lblVip.Text = "Vip";
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVip);
            Controls.Add(lblComentario);
            Controls.Add(lblEmail);
            Controls.Add(lblCiudad);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lbxAlta);
            Controls.Add(toolStrip1);
            Controls.Add(chkVip);
            Controls.Add(txtComentario);
            Controls.Add(txtEmail);
            Controls.Add(txtCiudad);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(picFoto);
            Name = "FrmAlta";
            Text = "FrmAlta";
            Controls.SetChildIndex(picFoto, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellidos, 0);
            Controls.SetChildIndex(txtCiudad, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(txtComentario, 0);
            Controls.SetChildIndex(chkVip, 0);
            Controls.SetChildIndex(toolStrip1, 0);
            Controls.SetChildIndex(lbxAlta, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblApellidos, 0);
            Controls.SetChildIndex(lblCiudad, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(lblComentario, 0);
            Controls.SetChildIndex(lblVip, 0);
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFoto;
        private ImageList imageList1;

        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtCiudad;
        private TextBox txtEmail;
        private TextBox txtComentario;
        private CheckBox chkVip;
        private OpenFileDialog openFileDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ListBox lbxAlta;
        private Label lblNombre;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnGuardar;
        private ToolStripButton toolStripButton5;
        private Label lblApellidos;
        private Label lblCiudad;
        private Label lblEmail;
        private Label lblComentario;
        private Label lblVip;
    }
}