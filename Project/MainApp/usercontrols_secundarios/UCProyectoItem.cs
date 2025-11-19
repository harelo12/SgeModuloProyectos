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
    public partial class UCProyectoItem : UserControl
    {

        private static int Id { get; set; }
        private static string Title { get; set; }
        private static string Description { get; set; }
        private static DateTime StartDate { get; set; }
        private static DateTime EndDate { get; set; }
        private static string Prioridad { get; set; }
        private static int LeaderId { get; set; }
        private static string Estado { get; set; }
        private static int Horas { get; set; }

        public UCProyectoItem(int? id, string title, string description, DateTime? startDate, DateTime? enddate, string prioridad, int? leaderId, string estado, int horas)
        {
            InitializeComponent();
            Id = id ?? 0;
            Title = title;
            Description = description;
            StartDate = startDate ?? DateTime.MinValue;
            EndDate = enddate ?? DateTime.MinValue; 
            Prioridad = prioridad;
            LeaderId = leaderId ?? 0;
            Estado = estado;
            Horas = horas;

            lblTitle.Text = title;
            lblDesc.Text = description;
            lblHoras.Text = $"Total Horas: {horas}h";
            lblprioridad.Text = $"Prioridad: {prioridad}";
            lblestado.Text = $"Estado: {estado}";
            lblfechaentrega .Text = enddate.HasValue ? $"Fecha Entrega: {enddate.Value.ToShortDateString()}" : "Fecha Entrega: N/A";
        }

        private void UCProyectoItem_Load(object sender, EventArgs e)
        {

        }

        private void UCProyectoItem_Click(object sender, EventArgs e)
        {


        }

        private void UCProyectoItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnOpciones, new Point(0, btnOpciones.Height));
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var detalleForm = new formularios_secundarios.ProyectoDetalle(Id);
            detalleForm.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificarForm = new formularios_secundarios.ProyectoModificacion(Id);
            modificarForm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // eliminar
            }
        }
    }
}
