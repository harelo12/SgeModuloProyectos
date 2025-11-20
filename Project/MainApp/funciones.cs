using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp
{
    public static class funciones
    {
        public static void CargarUC<T>(Panel panel) where T : UserControl, new()
        {
            panel.Controls.Clear();

            var uc = new T();
            uc.Dock = DockStyle.Fill;

            panel.Controls.Add(uc);
        }


    }
}
