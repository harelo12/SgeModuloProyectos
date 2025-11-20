using ProjectManagement.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectManagement.Core.Projects;
using static System.Net.Mime.MediaTypeNames;
namespace MainApp.formularios_secundarios
{
    public partial class TareaModificacion : Form
    {
        private int? tareaId;
        public TareaModificacion(int? id)
        {
            InitializeComponent();
            tareaId = id;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TareaModificacion_Load(object sender, EventArgs e)
        {
            using (var reader = Projects.getTask((int)tareaId))
            {
                var task = Projects.ToTask(reader);

                textNombre.Text = task.Title;
                textDescripcion.Text = task.Description;
                dateInicio.Value = task.StartDate;
                if (task.EndDate.HasValue)
                    dateFin.Value = task.EndDate.Value;
                else
                    dateFin.Checked = false;
                CargarComboProyectos(comboProyecto);
                comboProyecto.SelectedValue = task.ProjectID;
                Projects.CargarComboPrioridades(comboPrioridad);
                comboPrioridad.SelectedValue = task.Priority;
                Projects.CargarComboEmpleados(comboDelegado);
                comboDelegado.SelectedValue = task.DesignedEmployee;
                Projects.CargarComboEstados(comboEstado);
                if (task.Status.HasValue)
                    comboEstado.SelectedValue = task.Status.Value;
                else
                    comboEstado.SelectedIndex = -1;
                textHoras.Text = task.Hours.HasValue ? task.Hours.Value.Hours.ToString("F2") : "0.00";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int filas;
            using (var conn = new SqlConnection(getConnectionString()))
            {
                using (var adapter = new SqlDataAdapter())
                {
                    conn.Open();
                    var cmd = new SqlCommand("UPDATE Tasks SET Title=@title, Description=@desc, StartDate=@start, EndDate=@end, ProjectID=@project, Priority=@priority, DesignedEmployee=@employee,Hours=@hours ,Status=@status WHERE TaskID=@id", conn);
                    cmd.Parameters.AddWithValue("@title", textNombre.Text);
                    cmd.Parameters.AddWithValue("@desc", textDescripcion.Text);
                    cmd.Parameters.AddWithValue("@start", dateInicio.Value);
                    if (dateFin.Checked)
                        cmd.Parameters.AddWithValue("@end", dateFin.Value);
                    else
                        cmd.Parameters.AddWithValue("@end", DBNull.Value);
                    cmd.Parameters.AddWithValue("@project", (int)comboProyecto.SelectedValue);
                    cmd.Parameters.AddWithValue("@priority", (int)comboPrioridad.SelectedValue);
                    cmd.Parameters.AddWithValue("@employee", (int)comboDelegado.SelectedValue);
                    cmd.Parameters.AddWithValue("@hours", TimeSpan.Parse(textHoras.Text));
                    if (comboEstado.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@status", (int)comboEstado.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@status", DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", tareaId);
                    adapter.UpdateCommand = cmd;
                    filas = adapter.UpdateCommand.ExecuteNonQuery();
                }
            }
            if (filas > 0)
            {
                MessageBox.Show("Tarea actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
