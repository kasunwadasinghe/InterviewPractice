using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InterviewPractice.Data
{
    public static class DataService
    {
        private static string connectionString;
        static DataService()
        {
            connectionString = ConfigurationManager.ConnectionStrings["TestDbConnectionString"].ConnectionString;
        }

        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query,conn))
                {
                    conn.Open();
                    adapter.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }

        public static void DeleteRecord(SqlCommand cmd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void InsertRecord(SqlCommand cmd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void UpdateRecord(SqlCommand cmd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}