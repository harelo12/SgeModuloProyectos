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
using ProjectManagement.Core;
using System.Data.SqlClient;
namespace MainApp
{
    public partial class UCTareaItem : UserControl
    {
        private int? tareaId;
        private Tarea tarea;
        private Proyectos padre;
        public UCTareaItem(Proyectos uc, Tarea tarea)
        {
            InitializeComponent();
            this.padre = uc;
            this.tarea = tarea;
            this.tareaId = tarea.Id;

            this.lblTitle.Text = tarea.Title;
            this.lblDescripcion.Text = tarea.Description;

            if (tarea.Hours.HasValue)
                this.textHoras.Text = $"{tarea.Hours}";
            else
                this.textHoras.Text = "0.00";

            CargarComboEmpleados(comboDelegado);
            comboDelegado.SelectedValue = tarea.DesignedEmployee;

            CargarComboEstados(cmbStatus);
            cmbStatus.SelectedValue = tarea.Status;

            CargarComboPrioridades(comboPrioridad);
            comboPrioridad.SelectedValue = tarea.Priority;


            this.lblStartDate.Text = $"Inicio: {tarea.StartDate}";
            this.lblEndDate.Text = $"Fin: {tarea.EndDate}";
        }

        private void UCTareaItem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnOpciones, new Point(0, btnOpciones.Height));
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var detallesForm = new formularios_secundarios.TareaDetalle(tareaId);
            detallesForm.ShowDialog();

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificarForm = new formularios_secundarios.TareaModificacion(tareaId);
            modificarForm.ShowDialog();
            padre.cargarTarea(tarea.ProjectID);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta Tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(getConnectionString()))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM Tasks WHERE TaskID = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", tareaId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tarea eliminada correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                padre.cargarTarea(tarea.ProjectID);
            }
        }

        private void pnlDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}