using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

public class DataAccess
{
    private string connectionString;

    public DataAccess()
    {
        if (ConfigurationManager.ConnectionStrings["StudentDb"] != null)
        {
            connectionString = ConfigurationManager.ConnectionStrings["StudentDb"].ConnectionString;
        }
        else
        {
            throw new Exception("Connection string 'StudentDb' not found in configuration.");
        }
    }

    public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }

    public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}