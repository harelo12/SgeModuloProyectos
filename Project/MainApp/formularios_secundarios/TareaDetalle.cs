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
namespace MainApp.formularios_secundarios
{
    public partial class TareaDetalle : Form
    {
        private int? tareaId;
        public TareaDetalle(int? id)
        {
            InitializeComponent();
            tareaId = id;
        }

        private void TareaDetalle_Load(object sender, EventArgs e)
        {
            using (var reader = Projects.getTask((int)tareaId))
            {
                var task = Projects.ToTask(reader);
                textId.Text = tareaId.ToString();
                textNombre.Text = task.Title;
                textDesc.Text = task.Description;
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
    }
}
