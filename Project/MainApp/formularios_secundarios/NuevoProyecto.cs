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
namespace MainApp
{
    public partial class NuevoProyecto : Form
    {


        public NuevoProyecto()
        {
            InitializeComponent();

        }

        private void NuevoProyecto_Load(object sender, EventArgs e)
        {
            CargarComboEmpleados(comboDelegado);
            CargarComboPrioridades(comboPrioridad);
        }

        private void CrearCLICK(object sender, EventArgs e)
        {
            string titulo = textTitle.Text;
            string descripcion = textDescripcion.Text;
            DateTime fechaInicio = dateFechainicio.Value;
            DateTime? fechaFin = dateEntrega.Value;
            int prioridad = comboPrioridad.SelectedIndex + 1;
            int liderId = comboDelegado.SelectedIndex + 1;

            Project nuevoProyecto = new Project(null, titulo, descripcion, fechaInicio, fechaFin, prioridad, liderId, null, null);

            int result, projectId;
            int filasAfectadas = NewProject(nuevoProyecto, out result, out projectId);
            if (result == 1)
            {
                MessageBox.Show("Proyecto creado con éxito. ID del proyecto: " + projectId, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al crear el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
