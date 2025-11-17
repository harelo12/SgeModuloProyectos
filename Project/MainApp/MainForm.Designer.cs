namespace MainApp
{
    partial class MainForm
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hojaDeDatoscsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hojaDeDatoscsvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.inicioToolStripMenuItem,
            this.proyectosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarProyectosToolStripMenuItem,
            this.exportarEmpleadosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarProyectosToolStripMenuItem
            // 
            this.exportarProyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hojaDeDatoscsvToolStripMenuItem});
            this.exportarProyectosToolStripMenuItem.Image = global::MainApp.Properties.Resources.Pictogrammers_Material_Export_variant2;
            this.exportarProyectosToolStripMenuItem.Name = "exportarProyectosToolStripMenuItem";
            this.exportarProyectosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportarProyectosToolStripMenuItem.Text = "Exportar Proyectos";
            this.exportarProyectosToolStripMenuItem.Click += new System.EventHandler(this.exportarProyectosToolStripMenuItem_Click);
            // 
            // hojaDeDatoscsvToolStripMenuItem
            // 
            this.hojaDeDatoscsvToolStripMenuItem.Image = global::MainApp.Properties.Resources.Bootstrap_Bootstrap_Bootstrap_filetype_csv1;
            this.hojaDeDatoscsvToolStripMenuItem.Name = "hojaDeDatoscsvToolStripMenuItem";
            this.hojaDeDatoscsvToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.hojaDeDatoscsvToolStripMenuItem.Text = "Hoja de datos (csv)";
            // 
            // exportarEmpleadosToolStripMenuItem
            // 
            this.exportarEmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hojaDeDatoscsvToolStripMenuItem1});
            this.exportarEmpleadosToolStripMenuItem.Image = global::MainApp.Properties.Resources.Pictogrammers_Material_Export_variant2;
            this.exportarEmpleadosToolStripMenuItem.Name = "exportarEmpleadosToolStripMenuItem";
            this.exportarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportarEmpleadosToolStripMenuItem.Text = "Exportar Empleados";
            // 
            // hojaDeDatoscsvToolStripMenuItem1
            // 
            this.hojaDeDatoscsvToolStripMenuItem1.Image = global::MainApp.Properties.Resources.Bootstrap_Bootstrap_Bootstrap_filetype_csv1;
            this.hojaDeDatoscsvToolStripMenuItem1.Name = "hojaDeDatoscsvToolStripMenuItem1";
            this.hojaDeDatoscsvToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.hojaDeDatoscsvToolStripMenuItem1.Text = "Hoja de datos (csv)";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.proyectosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 665);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Proyectos";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hojaDeDatoscsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hojaDeDatoscsvToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

