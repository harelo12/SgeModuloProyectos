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
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                this.AutoScrollPosition = new Point(0, 0);
            }));
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
