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
        // Nota: Los parámetros del constructor deben coincidir con la definición de la tabla si se usa para crear tareas,
        // pero por ahora, solo usamos los parámetros que envías en el ejemplo (título, descripción, horas).

        public UCTareaItem(string titulo, string descripcion, int horas)
        {
            InitializeComponent();

            // **Asignación a los nuevos nombres de control (de la mejora estética)**
            this.lblTitle.Text = titulo;
            this.lblDescription.Text = descripcion;

            // Asumiendo que 'horas' es un entero que representa horas totales, lo formateamos.
            this.lblHours.Text = $"Horas: {horas}";

            // Ejemplo de inicialización de otros campos (no se proporcionaron datos, solo texto por defecto)
            this.lblPriority.Text = "Prioridad: Media"; // Asignar un valor por defecto o cargar datos reales
            this.cmbStatus.Items.AddRange(new object[] { "Pendiente", "En Curso", "Finalizada" });
            this.cmbStatus.SelectedIndex = 0; // Estado inicial: Pendiente
            this.lblStartDate.Text = "Inicio: N/A";
            this.lblEndDate.Text = "Fin: N/A";
        }

        private void UCTareaItem_Load(object sender, EventArgs e)
        {
            // Puedes añadir lógica de carga aquí si es necesario.
        }
    }
}