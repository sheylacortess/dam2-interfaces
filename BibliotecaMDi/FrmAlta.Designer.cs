namespace BibliotecaMDi
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
            openFileDialog1 = new OpenFileDialog();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            lblNuevo = new Label();
            ckbNuevo = new CheckBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCargarFoto = new Button();
            lblFoto = new Label();
            picPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPortada).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(218, 53);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(218, 106);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 1;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(218, 166);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(100, 23);
            txtEditorial.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(85, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(62, 28);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 15F);
            lblAutor.Location = new Point(85, 101);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(62, 28);
            lblAutor.TabIndex = 4;
            lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 15F);
            lblEditorial.Location = new Point(85, 161);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(85, 28);
            lblEditorial.TabIndex = 5;
            lblEditorial.Text = "Editorial";
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Font = new Font("Segoe UI", 15F);
            lblNuevo.Location = new Point(85, 221);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(70, 28);
            lblNuevo.TabIndex = 6;
            lblNuevo.Text = "Nuevo";
            // 
            // ckbNuevo
            // 
            ckbNuevo.AutoSize = true;
            ckbNuevo.Font = new Font("Segoe UI", 20F);
            ckbNuevo.Location = new Point(229, 226);
            ckbNuevo.Name = "ckbNuevo";
            ckbNuevo.Size = new Size(15, 14);
            ckbNuevo.TabIndex = 7;
            ckbNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 15F);
            btnGuardar.Location = new Point(134, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 41);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 15F);
            btnLimpiar.Location = new Point(261, 287);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 41);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Font = new Font("Segoe UI", 15F);
            btnCargarFoto.Location = new Point(400, 287);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(131, 41);
            btnCargarFoto.TabIndex = 10;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Segoe UI", 15F);
            lblFoto.Location = new Point(413, 35);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(126, 28);
            lblFoto.TabIndex = 11;
            lblFoto.Text = "Foto Portada";
            // 
            // picPortada
            // 
            picPortada.Location = new Point(423, 90);
            picPortada.Name = "picPortada";
            picPortada.Size = new Size(108, 139);
            picPortada.TabIndex = 12;
            picPortada.TabStop = false;
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 422);
            Controls.Add(picPortada);
            Controls.Add(lblFoto);
            Controls.Add(btnCargarFoto);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(ckbNuevo);
            Controls.Add(lblNuevo);
            Controls.Add(lblEditorial);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "FrmAlta";
            Text = "FrmAlta";
            ((System.ComponentModel.ISupportInitialize)picPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblEditorial;
        private Label lblNuevo;
        private CheckBox ckbNuevo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCargarFoto;
        private Label lblFoto;
        private PictureBox picPortada;
    }
}