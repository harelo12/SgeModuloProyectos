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
    public partial class UCProyectoItem : UserControl
    {
        public UCProyectoItem(string nombre, string descripcion, int horas)
        {
            InitializeComponent();
            lblTitle.Text = nombre;
            lblDesc.Text = descripcion;
            lblHoras.Text = $"Total Horas: {horas}h";
        }

        private void UCProyectoItem_Load(object sender, EventArgs e)
        {

        }

        private void UCProyectoItem_Click(object sender, EventArgs e)
        {
           

        }

        private void UCProyectoItem_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
