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

namespace MainApp.formularios_secundarios
{
    public partial class ProyectoDetalle : Form
    {
        private int proyectoId;

        public ProyectoDetalle(int? id)
        {
            InitializeComponent();

            if (id == null)
            {
                MessageBox.Show("ID de proyecto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            proyectoId = (int)id;
        }

        private void ProyectoDetalle_Load(object sender, EventArgs e)
        {

            using (var reader = Projects.getProject(proyectoId))
            {
                var project = Projects.ToProject(reader);
                textId.Text = proyectoId.ToString();
                textTitulo.Text = project.Title;
                textDesc.Text = project.Description;
                dateInicio.Value = project.StartDate;
                if (project.EndDate.HasValue)
                    dateEntrega.Value = project.EndDate.Value;
                else
                    dateEntrega.Checked = false;
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
    }
}
