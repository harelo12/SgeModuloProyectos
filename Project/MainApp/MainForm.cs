using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MainApp.funciones;
namespace MainApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarUC<Main>(panel1);
        }


        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarUC<Proyectos>(panel1);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            //CargarUC<Empleados>(panel1);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarUC<Main>(panel1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void exportarProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TareasJSON(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void TareasCSV(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ProyectosJson(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void proyectosCSVExportCLICK(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void empleadosJson(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void empleadosCsv(object sender, EventArgs e)
        {
            MessageBox.Show("aun no esta disponible esta parte", "quieto paraooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
