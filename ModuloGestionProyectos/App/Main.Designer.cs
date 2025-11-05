namespace App
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.asdasToolStripMenuItem,
            this.asdToolStripMenuItem1,
            this.asdToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.asdToolStripMenuItem.Text = "Inicio";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.asdToolStripMenuItem_Click);
            // 
            // asdasToolStripMenuItem
            // 
            this.asdasToolStripMenuItem.Name = "asdasToolStripMenuItem";
            this.asdasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.asdasToolStripMenuItem.Text = "Proyectos";
            // 
            // asdToolStripMenuItem1
            // 
            this.asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            this.asdToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.asdToolStripMenuItem1.Text = "Tareas";
            // 
            // asdToolStripMenuItem2
            // 
            this.asdToolStripMenuItem2.Name = "asdToolStripMenuItem2";
            this.asdToolStripMenuItem2.Size = new System.Drawing.Size(77, 20);
            this.asdToolStripMenuItem2.Text = "Empleados";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 629);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Proyectos";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
    }
}

