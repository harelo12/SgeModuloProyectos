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
        

        public UCTareaItem(string titulo, string descripcion, int horas)
        {
            InitializeComponent();
            this.titulo.Text = titulo;
            this.descripcion.Text = descripcion;
            this.comboBox1.Text = horas.ToString();
          
        }

        private void UCTareaItem_Load(object sender, EventArgs e)
        {

        }
    }
}
