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

        public DAL(string dbPath)//פעולה המקבלת מחרוזת עם נתיב מלא לקובץ מסד הנתונים ובונה דאל
        {
            this.dbPath = dbPath;
            ConnectionString = string.Format(connectionStr, this.dbPath);
            sqlConnection = new SqlConnection(ConnectionString);
        }

        public DataTable GetDataTable(string sql)//פעולה המקבלת מחרוזת אסקיואל מסוג סלקט מבצעת ומחזירה טבלה של דאטה טייבל
        {
            DataTable results = new DataTable();

            using (sqlConnection = new SqlConnection(ConnectionString))
            using (command = new SqlCommand(sql, sqlConnection))
            using (adapter = new SqlDataAdapter(command))
                adapter.Fill(results);
            return results;
        }

        public int UpdateDB(string sql)//מקבלת מחרוזת אסקיואל מסוג הוספה מחיקה או עדכון מבצעת ומחזירה את מספר הרשומות שהושפעות מהביצוע 
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