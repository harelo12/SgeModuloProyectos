namespace MainApp
{
    partial class UCProyectoItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblprioridad = new System.Windows.Forms.Label();
            this.lblfechaentrega = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Proyecto";
            this.lblTitle.Click += new System.EventHandler(this.UCProyectoItem_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblHoras.Location = new System.Drawing.Point(8, 125);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(83, 13);
            this.lblHoras.TabIndex = 2;
            this.lblHoras.Text = "Total Horas: 0h";
            this.lblHoras.Click += new System.EventHandler(this.UCProyectoItem_Click);
            // 
            // btnOpciones
            // 
            this.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnOpciones.Location = new System.Drawing.Point(295, 0);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(35, 35);
            this.btnOpciones.TabIndex = 3;
            this.btnOpciones.Text = "⋮";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(133, 43);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 5;
            this.lblestado.Text = "Activo";
            this.lblestado.Click += new System.EventHandler(this.UCProyectoItem_Click);
            // 
            // lblprioridad
            // 
            this.lblprioridad.AutoSize = true;
            this.lblprioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblprioridad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprioridad.Location = new System.Drawing.Point(9, 43);
            this.lblprioridad.Name = "lblprioridad";
            this.lblprioridad.Size = new System.Drawing.Size(40, 13);
            this.lblprioridad.TabIndex = 6;
            this.lblprioridad.Text = "Media";
            this.lblprioridad.Click += new System.EventHandler(this.UCProyectoItem_Click);
            // 
            // lblfechaentrega
            // 
            this.lblfechaentrega.AutoSize = true;
            this.lblfechaentrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblfechaentrega.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaentrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblfechaentrega.Location = new System.Drawing.Point(218, 125);
            this.lblfechaentrega.Name = "lblfechaentrega";
            this.lblfechaentrega.Size = new System.Drawing.Size(109, 13);
            this.lblfechaentrega.TabIndex = 7;
            this.lblfechaentrega.Text = "Entrega: 01/01/2025";
            this.lblfechaentrega.Click += new System.EventHandler(this.UCProyectoItem_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnOpciones);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(5, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(330, 35);
            this.panelHeader.TabIndex = 8;
            // 
            // lblDesc
            // 
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDesc.Location = new System.Drawing.Point(5, 74);
            this.lblDesc.Multiline = true;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.ReadOnly = true;
            this.lblDesc.Size = new System.Drawing.Size(306, 48);
            this.lblDesc.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetallesToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // verDetallesToolStripMenuItem
            // 
            this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verDetallesToolStripMenuItem.Text = "Ver Detalles";
            this.verDetallesToolStripMenuItem.Click += new System.EventHandler(this.verDetallesToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // UCProyectoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblprioridad);
            this.Controls.Add(this.lblfechaentrega);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.panelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCProyectoItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(340, 144);
            this.Load += new System.EventHandler(this.UCProyectoItem_Load);
            this.Click += new System.EventHandler(this.UCProyectoItem_Click);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblprioridad;
        private System.Windows.Forms.Label lblfechaentrega;
        private System.Windows.Forms.TextBox lblDesc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}