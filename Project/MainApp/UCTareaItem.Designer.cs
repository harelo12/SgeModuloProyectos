namespace MainApp
{
    partial class UCTareaItem
    {
        // ... (Sección de Dispose, no se modifica) ...

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDetails.SuspendLayout();
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
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(0, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(346, 45);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Descripción de la tarea (puede ocupar varias líneas)";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(578, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(120, 21);
            this.cmbStatus.TabIndex = 0;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.Location = new System.Drawing.Point(356, 5);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(100, 15);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Horas: 00:00:00";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.Location = new System.Drawing.Point(466, 5);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 15);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Inicio: 01/01/2025";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.Location = new System.Drawing.Point(466, 25);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 15);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "Fin: 01/01/2025";
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(356, 25);
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
            this.pnlDetails.Controls.Add(this.button1);
            this.pnlDetails.Controls.Add(this.lblPriority);
            this.pnlDetails.Controls.Add(this.lblEndDate);
            this.pnlDetails.Controls.Add(this.lblStartDate);
            this.pnlDetails.Controls.Add(this.lblHours);
            this.pnlDetails.Controls.Add(this.lblDescription);
            this.pnlDetails.Location = new System.Drawing.Point(10, 28);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(688, 58);
            this.pnlDetails.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCTareaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCTareaItem";
            this.Size = new System.Drawing.Size(708, 98);
            this.Load += new System.EventHandler(this.UCTareaItem_Load);
            this.pnlDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Button button1;
    }
}