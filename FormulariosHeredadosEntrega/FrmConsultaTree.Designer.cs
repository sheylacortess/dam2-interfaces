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
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(75, 185);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(274, 206);
            treeView1.TabIndex = 1;
            // 
            // FrmConsultaTree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Name = "FrmConsultaTree";
            Text = "FrmConsultaTree";
            Controls.SetChildIndex(treeView1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
    }
}