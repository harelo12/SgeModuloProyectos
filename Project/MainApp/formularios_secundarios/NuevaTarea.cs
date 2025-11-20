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
namespace MainApp
{
    public partial class NuevaTarea : Form
    {
        public NuevaTarea()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NuevaTarea_Load(object sender, EventArgs e)
        {
            CargarComboPrioridades(comboPrioridad);
            CargarComboEmpleados(comboDelegado);
            CargarComboProyectos(ComboProyecto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int projectId = (int)ComboProyecto.SelectedValue;
            int designedEmployeeId = (int)comboDelegado.SelectedValue;
            Tarea t = new Tarea(null, projectId, designedEmployeeId, textTitulo.Text, textDesc.Text, null, dateInicio.Value, dateEntrega.Value, (int)comboPrioridad.SelectedValue, null);

            int result, taskId;
            int filasAfectadas = ProjectManagement.Core.Projects.NewTask(t, out result, out taskId);
            if (result == 1)
            {
                MessageBox.Show("Tarea creada con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al crear la tarea. Código de error: " + result);
            }
        }
    }
}
