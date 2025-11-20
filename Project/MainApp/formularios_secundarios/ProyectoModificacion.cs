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
namespace MainApp.formularios_secundarios
{
    public partial class ProyectoModificacion : Form
    {
        private int? proyectoId;

        public ProyectoModificacion(int? id)
        {
            InitializeComponent();
            proyectoId = id;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProyectoModificacion_Load(object sender, EventArgs e)
        {
            using (var reader = Projects.getProject((int)proyectoId))
            {
                var project = Projects.ToProject(reader);

                textTitulo.Text = project.Title;
                textDescripcion.Text = project.Description;
                dateInicio.Value = project.StartDate;
                if (project.EndDate.HasValue)
                    dateFin.Value = project.EndDate.Value;
                else
                    dateFin.Checked = false;
                Projects.CargarComboPrioridades(comboPrioridad);
                comboPrioridad.SelectedValue = project.Priority;
                Projects.CargarComboEmpleados(comboDelegado);
                comboDelegado.SelectedValue = project.LeaderID;
                Projects.CargarComboEstados(comboEstado);
                if (project.Status.HasValue)
                    comboEstado.SelectedValue = project.Status.Value;
                else
                    comboEstado.SelectedIndex = -1;
                textHoras.Text = project.TotalHours.HasValue ? project.TotalHours.Value.TotalHours.ToString("F2") : "0.00";

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
                    var cmd = new SqlCommand("UPDATE Projects SET Title=@title, Description=@desc, StartDate=@start, EndDate=@end, Priority=@priority, LeaderID=@leader,TotalHours=@hours, Status=@status WHERE ProjectID=@id", conn);
                    cmd.Parameters.AddWithValue("@title", textTitulo.Text);
                    cmd.Parameters.AddWithValue("@desc", textDescripcion.Text);
                    cmd.Parameters.AddWithValue("@start", dateInicio.Value);
                    if (dateFin.Checked)
                        cmd.Parameters.AddWithValue("@end", dateFin.Value);
                    else
                        cmd.Parameters.AddWithValue("@end", DBNull.Value);
                    cmd.Parameters.AddWithValue("@priority", (int)comboPrioridad.SelectedValue);
                    cmd.Parameters.AddWithValue("@leader", (int)comboDelegado.SelectedValue);
                    cmd.Parameters.AddWithValue("@hours", TimeSpan.Parse(textHoras.Text));
                    if (comboEstado.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@status", (int)comboEstado.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@status", DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", proyectoId);
                    adapter.UpdateCommand = cmd;
                    filas = adapter.UpdateCommand.ExecuteNonQuery();
                }
            }
            if (filas == 1)
            {
                MessageBox.Show("Proyecto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
