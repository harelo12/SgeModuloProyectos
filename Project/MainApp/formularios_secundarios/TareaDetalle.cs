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

        }
    }
}
