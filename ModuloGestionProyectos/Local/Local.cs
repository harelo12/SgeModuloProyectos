using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local
{
    public static class Local
    {
        public static SqlDataAdapter sqlDataAdapter;
        public static DataTable dataTable;
        public static SqlCommandBuilder sqlCommandBuilder;

        public static string ConnectionString = null;
        public static string ProjectSelect = "";
        public static string TaskSelect = "";
        public static string EmployeeSelect = "";

        private static void InicializarConnectionString()
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                ConnectionString = "Server=segundo150\\segundo;Database=Dam2_HaranElola;Trusted_Connection=True;";
            }

        }

        public static void CargarTabla(DataGridView dataGrid, string strPk, string Select)
        {
            InicializarConnectionString();
            try
            {
                var conection = new SqlConnection(ConnectionString);

                conection.Open();
                sqlDataAdapter = new SqlDataAdapter(Select, conection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                CargarComandos(conection, strPk);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataTable.Columns[strPk].AutoIncrement = true;
                dataTable.Columns[strPk].AutoIncrementSeed = -1;
                dataTable.Columns[strPk].AutoIncrementStep = -1;

                DataColumn[] primaryKey = { dataTable.Columns[strPk] };
                dataTable.PrimaryKey = primaryKey;

                dataGrid.DataSource = dataTable;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                conection.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
