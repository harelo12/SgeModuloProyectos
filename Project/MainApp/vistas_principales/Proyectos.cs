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
    public partial class Proyectos : UserControl
    {
        public Proyectos()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Proyectos_Load(object sender, EventArgs e)
        {

            RecargarProyectos();
            var lblMsg = new Label();
            lblMsg.Text = "Haz doble click en un proyecto para mostrar todas sus tareas.\n(funciona por la zona de debajo de los 3 puntitos)";
            lblMsg.BackColor = Color.LightYellow;
            lblMsg.AutoSize = true;
            lblMsg.Padding = new Padding(5);
            lblMsg.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(lblMsg);
            lblMsg.BringToFront();
            lblMsg.Location = new Point(20, 50);

            await Task.Delay(5000);
            this.Controls.Remove(lblMsg);
            lblMsg.Dispose();

        }


        public void RecargarProyectos()
        {
            flowPanelProyectos.Controls.Clear();

            var projects = GetAllProjects();

            foreach (var p in projects)
            {
                var uc1 = new UCProyectoItem(this, p);
                flowPanelProyectos.Controls.Add(uc1);
            }

            int contproyectos = flowPanelProyectos.Controls.Count;
            int conttareas = Projects.GetAllTasks().Count;
            lblproyectostareascont.Text = $"Proyecto/s: {contproyectos}   |   Tarea/s: {conttareas}";
        }


        private void nuevoProyectoClick(object sender, EventArgs e)
        {
            var frm = new NuevoProyecto();
            frm.ShowDialog();
            RecargarProyectos();
            flowPanelTareas.Controls.Clear();
        }

        private void NuevaTareaClick(object sender, EventArgs e)
        {
            var frm = new NuevaTarea();
            frm.ShowDialog();
            flowPanelTareas.Controls.Clear();
        }
        public void cargarTarea(int idProyecto)
        {
            flowPanelTareas.Controls.Clear();
            var tareas = Projects.GetAllTasks();
            foreach (var t in tareas)
            {
                if (t.ProjectID == idProyecto)
                {
                    var uc1 = new UCTareaItem(this, t);
                    flowPanelTareas.Controls.Add(uc1);
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
