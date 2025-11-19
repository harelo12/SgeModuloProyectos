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
    public partial class UCTareaItem : UserControl
    {
        private int? tareaId;
        public UCTareaItem(int? id, int? projectid, int? designedEmp, string titulo, string descripcion, int horas, DateTime? startdate, DateTime? enddate, String priority = null, string status = null)
        {
            InitializeComponent();

            this.tareaId = id;

            this.lblTitle.Text = titulo;
            this.lblDescripcion.Text = descripcion;


            this.textHoras.Text = $"Horas: {horas}";


            this.lblPriority.Text = "Prioridad: Media"; 
            this.cmbStatus.Items.AddRange(new object[] { "Pendiente", "En Curso", "Finalizada" });
            this.cmbStatus.SelectedIndex = 0;
            this.lblStartDate.Text = "Inicio: N/A";
            this.lblEndDate.Text = "Fin: N/A";
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
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta Tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // eliminar
            }
        }
    }
}