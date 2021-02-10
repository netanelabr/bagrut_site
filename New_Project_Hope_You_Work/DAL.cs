using System;
using System.Data;
using System.Data.SqlClient;

namespace New_Project_Hope_You_Work
{
    public class DAL
    {
        private string dbPath;
        private string ConnectionString;
        private string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        public DAL(string dbPath)
        {
            this.dbPath = dbPath;
            ConnectionString = string.Format(connectionStr, this.dbPath);
            sqlConnection = new SqlConnection(ConnectionString);
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable results = new DataTable();

            using (sqlConnection = new SqlConnection(ConnectionString))
            using (command = new SqlCommand(sql, sqlConnection))
            using (adapter = new SqlDataAdapter(command))
                adapter.Fill(results);
            return results;
        }

        public int UpdateDB(string sql)
        {
            int rowsEffected;
            sqlConnection = new SqlConnection(ConnectionString);
            command = new SqlCommand(sql, sqlConnection);
            adapter = new SqlDataAdapter(command);
            command.CommandText = sql;
            sqlConnection.Open();
            rowsEffected = command.ExecuteNonQuery();
            sqlConnection.Close();
            return rowsEffected;
        }

        public DataSet GetDataSet(string sql)
        {
            DataSet ds = new DataSet();

            command = new SqlCommand(sql, sqlConnection);
            adapter = new SqlDataAdapter(command);
            command.CommandText = sql;
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            return ds;
        }
    }
}