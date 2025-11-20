using Microsoft.Extensions.Configuration;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using System.Windows.Forms;

namespace ProjectManagement.Core
{
    public static partial class Projects
    {
        private static readonly string ConnectionString;
        public static string EmployeesSelect = "SELECT [EmployeeID]\r\n      ,[LastName]\r\n      ,[FirstName]\r\n      ,[Title]\r\n      ,[TitleOfCourtesy]\r\n      ,[BirthDate]\r\n      ,[HireDate]\r\n      ,[Address]\r\n      ,[City]\r\n      ,[Region]\r\n      ,[PostalCode]\r\n      ,[Country]\r\n      ,[HomePhone]\r\n      ,[Extension]\r\n      ,[Photo]\r\n      ,[Notes]\r\n      ,[ReportsTo]\r\n      ,[PhotoPath]\r\n  FROM [ProyectoSGE].[dbo].[Employees]\r\n";
        public static string PrioritiesSelect = "SELECT [PriorityID]\r\n      ,[Description]\r\n  FROM [ProyectoSGE].[dbo].[Priorities]\r\n";
        public static string StatusSelect = "SELECT [Status]\r\n      ,[Description]\r\n  FROM [ProyectoSGE].[dbo].[Status]\r\n";
        public static string ProjectsSelect = "SELECT [ProjectID]\r\n      ,[Title]\r\n      ,[Description]\r\n      ,[StartDate]\r\n      ,[EndDate]\r\n      ,[Priority]\r\n      ,[LeaderID]\r\n      ,[Status]\r\n      ,[TotalHours]\r\n  FROM [ProyectoSGE].[dbo].[Projects]\r\n";
        public static string TaskSelect = "SELECT [TaskID]\r\n      ,[ProjectID]\r\n      ,[DesignedEmployee]\r\n      ,[Title]\r\n      ,[Description]\r\n      ,[Hours]\r\n      ,[StartDate]\r\n      ,[EndDate]\r\n      ,[Priority]\r\n      ,[Status]\r\n  FROM [ProyectoSGE].[dbo].[Tasks]\r\n";

        static Projects()
        {
            Env.Load(@"G:\HaranElola\SGE\SgeModuloProyectos\Project\ProjectManagement.Core\.env");

            ConnectionString = Environment.GetEnvironmentVariable("CONN_STRING"); // cargamos la connsrtring

            if (string.IsNullOrEmpty(ConnectionString))
                throw new Exception("No se ha encontrado \"CONN_STRING\" en el archivo .env");
        }
        public static string getConnectionString()
        {
            return ConnectionString;
        }
        public static SqlDataReader getProject(int id)
        {
            var conn = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand("PR_getProject", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public static SqlDataReader getTask(int id)
        {
            var conn = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand("PR_getTask", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static List<Project> GetAllProjects()
        {
            var proyectos = new List<Project>();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(ProjectsSelect, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        proyectos.Add(new Project(
                            reader["ProjectID"] as int?,
                            reader["Title"] as string,
                            reader["Description"] as string,
                            (DateTime)reader["StartDate"],
                            reader["EndDate"] as DateTime?,
                            (int)reader["Priority"],
                            (int)reader["LeaderID"],
                            reader["Status"] as int?,
                            reader["TotalHours"] as TimeSpan?
                        ));
                    }
                }
            }

            return proyectos;
        }

        public static List<Tarea> GetAllTasks()
        {
            var tareas = new List<Tarea>();
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(TaskSelect, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tareas.Add(new Tarea(
                            reader["TaskID"] as int?,
                            (int)reader["ProjectID"],
                            (int)reader["DesignedEmployee"],
                            reader["Title"] as string,
                            reader["Description"] as string,
                            reader["Hours"] as TimeSpan?,
                            (DateTime)reader["StartDate"],
                            reader["EndDate"] as DateTime?,
                            (int)reader["Priority"],
                            reader["Status"] as int?
                        ));
                    }
                }
            }
            return tareas;
        }
        public static Project ToProject(object source)
        {
            if (source == null) return null;

            int? id = null;
            string title = null;
            string description = null;
            DateTime startDate = DateTime.MinValue;
            DateTime? endDate = null;
            int priority = 0;
            int leaderID = 0;
            int? status = null;
            TimeSpan? totalHours = null;

            if (source is SqlDataReader reader)
            {
                if (!reader.HasRows) return null;
                reader.Read();

                id = reader["ProjectID"] as int?;
                title = reader["Title"] as string;
                description = reader["Description"] as string;
                startDate = (DateTime)reader["StartDate"];
                endDate = reader["EndDate"] as DateTime?;
                priority = (int)reader["Priority"];
                leaderID = (int)reader["LeaderID"];
                status = reader["Status"] as int?;
                totalHours = reader["TotalHours"] as TimeSpan?;
            }
            else if (source is DataTable dt && dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                id = row["ProjectID"] as int?;
                title = row["Title"] as string;
                description = row["Description"] as string;
                startDate = (DateTime)row["StartDate"];
                endDate = row["EndDate"] as DateTime?;
                priority = (int)row["Priority"];
                leaderID = (int)row["LeaderID"];
                status = row["Status"] as int?;
                totalHours = row["TotalHours"] as TimeSpan?;
            }
            else
            {
                throw new ArgumentException("el objeto no es un sqldatareader  ni un datatable valido");
            }

            return new Project(id, title, description, startDate, endDate, priority, leaderID, status, totalHours);
        }
        public static Tarea ToTask(object source)
        {
            if (source == null) return null;

            int? id = null;
            int projectID = 0;
            int designedEmployee = 0;
            string title = null;
            string description = null;
            TimeSpan? hours = null;
            DateTime startDate = DateTime.MinValue;
            DateTime? endDate = null;
            int priority = 0;
            int? status = null;

            if (source is SqlDataReader reader)
            {
                if (!reader.HasRows) return null;
                reader.Read();

                id = reader["TaskID"] as int?;
                projectID = (int)reader["ProjectID"];
                designedEmployee = (int)reader["DesignedEmployee"];
                title = reader["Title"] as string;
                description = reader["Description"] as string;
                hours = reader["Hours"] as TimeSpan?;
                startDate = (DateTime)reader["StartDate"];
                endDate = reader["EndDate"] as DateTime?;
                priority = (int)reader["Priority"];
                status = reader["Status"] as int?;
            }
            else if (source is DataTable dt && dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                id = row["TaskID"] as int?;
                projectID = (int)row["ProjectID"];
                designedEmployee = (int)row["DesignedEmployee"];
                title = row["Title"] as string;
                description = row["Description"] as string;
                hours = row["Hours"] as TimeSpan?;
                startDate = (DateTime)row["StartDate"];
                endDate = row["EndDate"] as DateTime?;
                priority = (int)row["Priority"];
                status = row["Status"] as int?;
            }
            else
            {
                throw new ArgumentException("el objeto no es un sqldatareader ni un datatable valido");
            }

            return new Tarea(id, projectID, designedEmployee, title, description, hours, startDate, endDate, priority, status);
        }


        public static int NewProject(Project p, out int result, out int projectId)
        {
            result = 0;
            projectId = 0;
            int affected_rows = 0;

            using (var conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PR_NewProject", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@title", p.Title);
                    cmd.Parameters.AddWithValue("@description", (object)p.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@startdate", p.StartDate);
                    cmd.Parameters.AddWithValue("@enddate", (object)p.EndDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@priority", p.Priority);
                    cmd.Parameters.AddWithValue("@leaderid", p.LeaderID);
                    cmd.Parameters.AddWithValue("@status", (object)p.Status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@totalhours", (object)p.TotalHours ?? DBNull.Value);

                    var paramResult = new SqlParameter("@p_result", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var paramProjectID = new SqlParameter("@p_projectID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(paramResult);
                    cmd.Parameters.Add(paramProjectID);

                    conn.Open();
                    affected_rows = cmd.ExecuteNonQuery();

                    result = (int)paramResult.Value;
                    // Falta manejar mejor la logica, de momento asi para que no me de muchos problemas 
                    if (result != 1)
                    {
                        return 0;
                    }
                    projectId = (int)paramProjectID.Value;
                }
            }

            return affected_rows;
        }
        public static int NewTask(Tarea t, out int result, out int taskId)
        {
            result = 0;
            taskId = 0;
            int affected_rows = 0;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PR_NewTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@projectID", t.ProjectID);
                    cmd.Parameters.AddWithValue("@designedEmployee", t.DesignedEmployee);
                    cmd.Parameters.AddWithValue("@title", t.Title);
                    cmd.Parameters.AddWithValue("@description", (object)t.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@hours", (object)t.Hours ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@startd", t.StartDate);
                    cmd.Parameters.AddWithValue("@endd", (object)t.EndDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@priority", t.Priority);
                    cmd.Parameters.AddWithValue("@status", (object)t.Status ?? DBNull.Value);
                    var paramResult = new SqlParameter("@p_result", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var paramTaskID = new SqlParameter("@p_taskID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(paramResult);
                    cmd.Parameters.Add(paramTaskID);
                    conn.Open();
                    affected_rows = cmd.ExecuteNonQuery();
                    result = (int)paramResult.Value;
                    // Falta manejar mejor la logica, de momento asi para que no me de muchos problemas 
                    if (result != 1)
                    {
                        return 0;
                    }
                    taskId = (int)paramTaskID.Value;
                }
            }
            return affected_rows;
        }
        public static void CargarComboEmpleados(ComboBox cb)
        {
            try
            {
                using (var conexion = new SqlConnection(getConnectionString()))
                {
                    conexion.Open();
                    var sqlDataAdapter = new SqlDataAdapter(EmployeesSelect, conexion);
                    var dt = new DataTable();
                    sqlDataAdapter.Fill(dt);

                    cb.DataSource = dt;
                    cb.ValueMember = "EmployeeID";
                    cb.DisplayMember = "FirstName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void CargarComboProyectos(ComboBox cb)
        {
            try
            {
                using (var conexion = new SqlConnection(getConnectionString()))
                {
                    conexion.Open();
                    var sqlDataAdapter = new SqlDataAdapter(ProjectsSelect, conexion);
                    var dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    cb.DataSource = dt;
                    cb.ValueMember = "ProjectID";
                    cb.DisplayMember = "Title";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CargarComboEstados(ComboBox cb)
        {
            try
            {
                using (var conexion = new SqlConnection(getConnectionString()))
                {
                    conexion.Open();
                    var sqlDataAdapter = new SqlDataAdapter(StatusSelect, conexion);
                    var dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    cb.DataSource = dt;
                    cb.ValueMember = "Status";
                    cb.DisplayMember = "Description";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CargarComboPrioridades(ComboBox cb)
        {
            try
            {
                using (var conexion = new SqlConnection(getConnectionString()))
                {
                    conexion.Open();
                    var sqlDataAdapter = new SqlDataAdapter(PrioritiesSelect, conexion);
                    var dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    cb.DataSource = dt;
                    cb.ValueMember = "PriorityID";
                    cb.DisplayMember = "Description";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public class Project
        {
            public Project(int? Id, string Title, string Description, DateTime StartDate, DateTime? EndDate, int Priority, int LeaderID, int? Status, TimeSpan? totalHours)
            {
                this.Id = Id;
                this.Title = Title;
                this.Description = Description;
                this.StartDate = StartDate;
                this.EndDate = EndDate;
                this.Priority = Priority;
                this.LeaderID = LeaderID;
                this.Status = Status;
                this.TotalHours = totalHours;
            }
            public int? Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public int Priority { get; set; }
            public int LeaderID { get; set; }
            public int? Status { get; set; }
            public TimeSpan? TotalHours { get; set; }
        }

        public class Tarea
        {
            public Tarea(int? Id, int ProjectID, int DesignedEmployee, string Title, string Description, TimeSpan? Hours, DateTime StartDate, DateTime? EndDate, int Priority, int? Status)
            {
                this.Id = Id;
                this.ProjectID = ProjectID;
                this.DesignedEmployee = DesignedEmployee;
                this.Title = Title;
                this.Description = Description;
                this.Hours = Hours;
                this.StartDate = StartDate;
                this.EndDate = EndDate;
                this.Priority = Priority;
                this.Status = Status;
            }
            public int? Id { get; set; }
            public int ProjectID { get; set; }
            public int DesignedEmployee { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public TimeSpan? Hours { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public int Priority { get; set; }
            public int? Status { get; set; }

        }



    }


}