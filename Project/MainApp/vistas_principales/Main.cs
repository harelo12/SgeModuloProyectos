using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectManagement.Core.Projects;
using ProjectManagement.Core;
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

            cargarDataGrid(ProjectsSelect, dtProyectos);
            cargarDataGrid(TaskSelect, dtTareas);

            txt1.Text = EjecutarScalar("SELECT COUNT(ProjectID) AS ProyectosActivos\r\nFROM [dbo].[Projects]\r\nWHERE [Status] <> 3;").ToString();
            txt2.Text = EjecutarScalar("SELECT COUNT(TaskID) AS TareasPendientes\r\nFROM [dbo].[Tasks]\r\nWHERE [Status] <> 3;").ToString();
            txt3.Text = EjecutarScalar("SELECT COUNT(TaskID) AS TareasCompletadas\r\nFROM [dbo].[Tasks]\r\nWHERE [Status] = 3;").ToString();
            txt5.Text = EjecutarScalar("SELECT COUNT(TaskID) AS VencenEstaSemana\r\nFROM [dbo].[Tasks]\r\nWHERE [Status] <> 3 \r\n  AND [EndDate] IS NOT NULL \r\n  AND [EndDate] BETWEEN GETDATE() AND DATEADD(day, 7, GETDATE());").ToString();
            txt6.Text = EjecutarScalar("SELECT COUNT(TaskID) AS TareasVencidas\r\nFROM [dbo].[Tasks]\r\nWHERE [Status] <> 3 \r\n  AND [EndDate] IS NOT NULL \r\n  AND [EndDate] < GETDATE();").ToString();
            txt7.Text = EjecutarScalar("SELECT COUNT(TaskID) AS TareasPrioridadAlta\r\nFROM [dbo].[Tasks]\r\nWHERE [Priority] = 1 \r\n  AND [Status] <> 3; ").ToString();

        }

        private void cargarDataGrid(string query, DataGridView dt)
        {
            using (var conn = new SqlConnection(getConnectionString()))
            {
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    dt.DataSource = table;
                    dt.ReadOnly = true;
                    dt.AllowUserToAddRows = false;
                    dt.AllowUserToDeleteRows = false;
                    dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
        }
        public static int EjecutarScalar(string query)
        {
            int resultado = 0;
            using (var conn = new SqlConnection(getConnectionString()))
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object res = cmd.ExecuteScalar();
                    if (res != null && res != DBNull.Value)
                    {
                        try
                        {
                            resultado = Convert.ToInt32(res);
                        }
                        catch
                        {
                            resultado = 0;
                        }
                    }
                }
            }
            return resultado;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
