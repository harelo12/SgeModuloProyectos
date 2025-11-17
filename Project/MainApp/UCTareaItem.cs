using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp
{
    public partial class UCTareaItem : UserControl
    {
        private Label lblTitulo;
        private Label lblDescripcion;
        private Button btnEliminar;
        private Button btnHoras;

        public UCTareaItem(string titulo, string descripcion, int horas)
        {
            InitializeComponent();

            // Configuración básica del UserControl
            this.Height = 80;
            this.Width = 710;
            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Padding = new Padding(5);

            // Label de título
            lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 25;
            this.Controls.Add(lblTitulo);

            // Label de descripción
            lblDescripcion = new Label();
            lblDescripcion.Text = descripcion;
            lblDescripcion.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDescripcion.Dock = DockStyle.Top;
            lblDescripcion.Height = 35;
            this.Controls.Add(lblDescripcion);

            // Botón para eliminar
            btnEliminar = new Button();
            btnEliminar.Text = "Eliminar";
            btnEliminar.Width = 80;
            btnEliminar.Height = 25;
            btnEliminar.Location = new Point(this.Width - 170, 10);
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Controls.Add(btnEliminar);

            // Botón para sumar horas
            btnHoras = new Button();
            btnHoras.Text = $"+{horas}h";
            btnHoras.Width = 60;
            btnHoras.Height = 25;
            btnHoras.Location = new Point(this.Width - 80, 10);
            btnHoras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Controls.Add(btnHoras);

            // Para ver los bordes y distinguir bien los items
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void UCTareaItem_Load(object sender, EventArgs e)
        {

        }
    }
}
