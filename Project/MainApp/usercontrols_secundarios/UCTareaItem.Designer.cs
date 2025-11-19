namespace MainApp
{
    partial class UCTareaItem
    {
        // ... (Sección de Dispose, no se modifica) ...

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textHoras = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.pnlDetails.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Título de la Tarea";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(562, 32);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(120, 21);
            this.cmbStatus.TabIndex = 0;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.Location = new System.Drawing.Point(203, 5);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(43, 15);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Horas: ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.Location = new System.Drawing.Point(476, 5);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 15);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Inicio: 01/01/2025";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.Location = new System.Drawing.Point(582, 5);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 15);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "Fin: 01/01/2025";
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(203, 30);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(100, 15);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Prioridad: X";
            // 
            // pnlDetails
            // 
            this.pnlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.lblResponsable);
            this.pnlDetails.Controls.Add(this.button2);
            this.pnlDetails.Controls.Add(this.textHoras);
            this.pnlDetails.Controls.Add(this.cmbStatus);
            this.pnlDetails.Controls.Add(this.lblDescripcion);
            this.pnlDetails.Controls.Add(this.lblPriority);
            this.pnlDetails.Controls.Add(this.lblEndDate);
            this.pnlDetails.Controls.Add(this.lblStartDate);
            this.pnlDetails.Controls.Add(this.lblHours);
            this.pnlDetails.Location = new System.Drawing.Point(10, 28);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(688, 58);
            this.pnlDetails.TabIndex = 1;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(360, 35);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(75, 13);
            this.lblResponsable.TabIndex = 9;
            this.lblResponsable.Text = "Responsable: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "sumar horas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textHoras
            // 
            this.textHoras.Location = new System.Drawing.Point(253, 4);
            this.textHoras.Name = "textHoras";
            this.textHoras.Size = new System.Drawing.Size(100, 20);
            this.textHoras.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 5);
            this.lblDescripcion.Multiline = true;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.ReadOnly = true;
            this.lblDescripcion.Size = new System.Drawing.Size(194, 48);
            this.lblDescripcion.TabIndex = 6;
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
            this.verDetallesToolStripMenuItem.Text = "Ver detalles";
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
            // btnOpciones
            // 
            this.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnOpciones.Location = new System.Drawing.Point(663, -1);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(35, 28);
            this.btnOpciones.TabIndex = 10;
            this.btnOpciones.Text = "⋮";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // UCTareaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnOpciones);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCTareaItem";
            this.Size = new System.Drawing.Size(708, 98);
            this.Load += new System.EventHandler(this.UCTareaItem_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TextBox lblDescripcion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TextBox textHoras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}