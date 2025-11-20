using ProjectManagement.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectManagement.Core.Projects;
using System.Data.SqlClient;
namespace MainApp
{
    public partial class UCProyectoItem : UserControl
    {
        private Proyectos padre;
        private int? Id;
        public UCProyectoItem(Proyectos padre, Project p)
        {
            InitializeComponent();

            this.padre = padre;
            Id = p.Id;

            lblTitle.Text = p.Title;
            lblDesc.Text = p.Description;
            lblHoras.Text = $"Total Horas: {p.TotalHours}h";
            CargarComboPrioridades(comboPrioridad);
            comboPrioridad.SelectedValue = p.Priority;
            CargarComboEstados(comboEstado);
            comboEstado.SelectedValue = p.Status;
            lblfechaentrega.Text = p.EndDate.HasValue ? $"Fecha Entrega: {p.EndDate.Value.ToShortDateString()}" : "Fecha Entrega: N/A";
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
            padre.RecargarProyectos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar \neste proyecto y todas las tareas relacionadas?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(getConnectionString()))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM Tasks WHERE ProjectID = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new SqlCommand("DELETE FROM Projects WHERE ProjectID = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Proyecto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                padre.RecargarProyectos();
            }
        }

        private void UCProyectoItem_DoubleClick(object sender, EventArgs e)
        {
            padre.cargarTarea((int)Id);
        }
    }
}
