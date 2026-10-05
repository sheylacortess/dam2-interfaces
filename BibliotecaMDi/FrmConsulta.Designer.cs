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
            lbAutor = new ListBox();
            lbEditorial = new ListBox();
            gbTipoConsulta.SuspendLayout();
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
            rbEditorial.TabStop = true;
            rbEditorial.Text = "Editorial";
            rbEditorial.UseVisualStyleBackColor = true;
            // 
            // rbAutor
            // 
            rbAutor.AutoSize = true;
            rbAutor.Location = new Point(15, 31);
            rbAutor.Name = "rbAutor";
            rbAutor.Size = new Size(55, 19);
            rbAutor.TabIndex = 0;
            rbAutor.TabStop = true;
            rbAutor.Text = "Autor";
            rbAutor.UseVisualStyleBackColor = true;
            // 
            // lbAutor
            // 
            lbAutor.FormattingEnabled = true;
            lbAutor.ItemHeight = 15;
            lbAutor.Location = new Point(126, 267);
            lbAutor.Name = "lbAutor";
            lbAutor.Size = new Size(120, 94);
            lbAutor.TabIndex = 1;
            // 
            // lbEditorial
            // 
            lbEditorial.FormattingEnabled = true;
            lbEditorial.ItemHeight = 15;
            lbEditorial.Location = new Point(325, 267);
            lbEditorial.Name = "lbEditorial";
            lbEditorial.Size = new Size(120, 94);
            lbEditorial.TabIndex = 2;
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 444);
            Controls.Add(lbEditorial);
            Controls.Add(lbAutor);
            Controls.Add(gbTipoConsulta);
            Name = "FrmConsulta";
            Text = "FrmConsulta";
            gbTipoConsulta.ResumeLayout(false);
            gbTipoConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTipoConsulta;
        private RadioButton rbEditorial;
        private RadioButton rbAutor;
        private ListBox lbAutor;
        private ListBox lbEditorial;
    }
}