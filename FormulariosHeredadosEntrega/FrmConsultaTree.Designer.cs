namespace FormulariosHeredadosEntrega
{
    partial class FrmConsultaTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaTree));
            treeView1 = new TreeView();
            pictureBox1 = new PictureBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtEmail = new TextBox();
            textBox5 = new TextBox();
            lblNombre = new Label();
            lblCiudad = new Label();
            lblEmail = new Label();
            lblApellidos = new Label();
            lblComentario = new Label();
            imageList1 = new ImageList(components);
            txtCiudad = new TextBox();
            txtEmail1 = new TextBox();
            txtComentario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(82, 410);
            treeView1.Margin = new Padding(6);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(619, 441);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(132, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 211);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1004, 426);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 39);
            txtNombre.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(1004, 498);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(345, 39);
            txtApellidos.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 39);
            txtEmail.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(0, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 39);
            textBox5.TabIndex = 14;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(788, 429);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(788, 583);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(89, 32);
            lblCiudad.TabIndex = 10;
            lblCiudad.Text = "Ciudad";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(788, 652);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 32);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "email";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(788, 505);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(112, 32);
            lblApellidos.TabIndex = 12;
            lblApellidos.Text = "Apellidos";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(788, 755);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(139, 32);
            lblComentario.TabIndex = 13;
            lblComentario.Text = "Comentario";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "usuario.png");
            imageList1.Images.SetKeyName(1, "estrella.png");
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(1004, 583);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(345, 39);
            txtCiudad.TabIndex = 16;
            // 
            // txtEmail1
            // 
            txtEmail1.Location = new Point(1004, 662);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(345, 39);
            txtEmail1.TabIndex = 17;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(1004, 755);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(345, 39);
            txtComentario.TabIndex = 18;
            // 
            // FrmConsultaTree
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(txtComentario);
            Controls.Add(txtEmail1);
            Controls.Add(txtCiudad);
            Controls.Add(lblComentario);
            Controls.Add(lblApellidos);
            Controls.Add(lblEmail);
            Controls.Add(lblCiudad);
            Controls.Add(lblNombre);
            Controls.Add(textBox5);
            Controls.Add(txtEmail);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(treeView1);
            Margin = new Padding(11, 13, 11, 13);
            Name = "FrmConsultaTree";
            Text = "FrmConsultaTree";
            Load += FrmConsultaTree_Load;
            Controls.SetChildIndex(treeView1, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellidos, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(textBox5, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblCiudad, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(lblApellidos, 0);
            Controls.SetChildIndex(lblComentario, 0);
            Controls.SetChildIndex(txtCiudad, 0);
            Controls.SetChildIndex(txtEmail1, 0);
            Controls.SetChildIndex(txtComentario, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private PictureBox pictureBox1;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox textBox3;
        private TextBox txtEmail;
        private TextBox textBox5;
        private Label lblNombre;
        private Label lblComentario;
        private Label lblCiudad;
        private Label lblEmail;
        private Label lblApellidos;
        private ImageList imageList1;
        private TextBox txtCiudad;
        private TextBox txtEmail1;
        private TextBox txtComentario;
    }
}