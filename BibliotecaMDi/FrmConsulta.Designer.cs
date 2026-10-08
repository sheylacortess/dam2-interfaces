namespace BibliotecaMDi
{
    partial class FrmConsulta
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
            gbTipoConsulta = new GroupBox();
            rbEditorial = new RadioButton();
            rbAutor = new RadioButton();
            lbxTitulo = new ListBox();
            lbxAutorEditorial = new ListBox();
            lblTitulo = new Label();
            lblAutorEditorial = new Label();
            lblFotoPortada = new Label();
            pbxPortada = new PictureBox();
            gbTipoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPortada).BeginInit();
            SuspendLayout();
            // 
            // gbTipoConsulta
            // 
            gbTipoConsulta.Controls.Add(rbEditorial);
            gbTipoConsulta.Controls.Add(rbAutor);
            gbTipoConsulta.Location = new Point(126, 75);
            gbTipoConsulta.Name = "gbTipoConsulta";
            gbTipoConsulta.Size = new Size(200, 100);
            gbTipoConsulta.TabIndex = 0;
            gbTipoConsulta.TabStop = false;
            gbTipoConsulta.Text = "Tipo Consulta";
            // 
            // rbEditorial
            // 
            rbEditorial.AutoSize = true;
            rbEditorial.Location = new Point(15, 56);
            rbEditorial.Name = "rbEditorial";
            rbEditorial.Size = new Size(68, 19);
            rbEditorial.TabIndex = 1;
            rbEditorial.Text = "Editorial";
            rbEditorial.UseVisualStyleBackColor = true;
            rbEditorial.CheckedChanged += rbEditorial_CheckedChanged;
            // 
            // rbAutor
            // 
            rbAutor.AutoSize = true;
            rbAutor.Location = new Point(15, 31);
            rbAutor.Name = "rbAutor";
            rbAutor.Size = new Size(55, 19);
            rbAutor.TabIndex = 0;
            rbAutor.Text = "Autor";
            rbAutor.UseVisualStyleBackColor = true;
            rbAutor.CheckedChanged += rbAutor_CheckedChanged;
            // 
            // lbxTitulo
            // 
            lbxTitulo.FormattingEnabled = true;
            lbxTitulo.ItemHeight = 15;
            lbxTitulo.Location = new Point(126, 222);
            lbxTitulo.Name = "lbxTitulo";
            lbxTitulo.Size = new Size(120, 94);
            lbxTitulo.TabIndex = 1;
            lbxTitulo.DoubleClick += lbxTitulo_DoubleClick;
            // 
            // lbxAutorEditorial
            // 
            lbxAutorEditorial.FormattingEnabled = true;
            lbxAutorEditorial.ItemHeight = 15;
            lbxAutorEditorial.Location = new Point(279, 222);
            lbxAutorEditorial.Name = "lbxAutorEditorial";
            lbxAutorEditorial.Size = new Size(120, 94);
            lbxAutorEditorial.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F);
            lblTitulo.Location = new Point(126, 195);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(49, 21);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Título";
            // 
            // lblAutorEditorial
            // 
            lblAutorEditorial.AutoSize = true;
            lblAutorEditorial.Font = new Font("Segoe UI", 12F);
            lblAutorEditorial.Location = new Point(279, 195);
            lblAutorEditorial.Name = "lblAutorEditorial";
            lblAutorEditorial.Size = new Size(112, 21);
            lblAutorEditorial.TabIndex = 4;
            lblAutorEditorial.Text = "Autor/Editorial";
            // 
            // lblFotoPortada
            // 
            lblFotoPortada.AutoSize = true;
            lblFotoPortada.Font = new Font("Segoe UI", 12F);
            lblFotoPortada.Location = new Point(445, 131);
            lblFotoPortada.Name = "lblFotoPortada";
            lblFotoPortada.Size = new Size(98, 21);
            lblFotoPortada.TabIndex = 5;
            lblFotoPortada.Text = "Foto Portada";
            // 
            // pbxPortada
            // 
            pbxPortada.Location = new Point(456, 181);
            pbxPortada.Name = "pbxPortada";
            pbxPortada.Size = new Size(99, 135);
            pbxPortada.TabIndex = 6;
            pbxPortada.TabStop = false;
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 444);
            Controls.Add(pbxPortada);
            Controls.Add(lblFotoPortada);
            Controls.Add(lblAutorEditorial);
            Controls.Add(lblTitulo);
            Controls.Add(lbxAutorEditorial);
            Controls.Add(lbxTitulo);
            Controls.Add(gbTipoConsulta);
            Name = "FrmConsulta";
            Text = "FrmConsulta";
            gbTipoConsulta.ResumeLayout(false);
            gbTipoConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbTipoConsulta;
        private RadioButton rbEditorial;
        private RadioButton rbAutor;
        private ListBox lbxTitulo;
        private ListBox lbxAutorEditorial;
        private Label lblTitulo;
        private Label lblAutorEditorial;
        private Label lblFotoPortada;
        private PictureBox pbxPortada;
    }
}