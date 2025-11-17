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

namespace ProjectManagement.Core
{
    public static partial class Projects
    {
        private static readonly string ConnectionString;

        static Projects()
        {
            Env.Load(@"G:\HaranElola\SGE\SgeModuloProyectos\Project\ProjectManagement.Core\.env");

            ConnectionString = Environment.GetEnvironmentVariable("CONN_STRING"); // cargamos la connsrtring

            if (string.IsNullOrEmpty(ConnectionString))
                throw new Exception("No se ha encontrado \"CONN_STRING\" en el archivo .env");
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
                    projectId = (int)paramProjectID.Value;
                }
            }

            return affected_rows;
        }

        public class Project
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public int Priority { get; set; }
            public int LeaderID { get; set; }
            public int? Status { get; set; }
            public TimeSpan? TotalHours { get; set; }
        }

        public class Task
        {

        }

        public class Employee
        {

        }


    }


}