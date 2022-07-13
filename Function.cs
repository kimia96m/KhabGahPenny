using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhabGahe_Penny
{
    class Function
    {
        protected SqlConnection GetConnection() {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "data source=DESKTOP-2V9E4U5; database=PennyHostel;integrated security=True";
            return sql;
        }
        public DataSet getData(string query) {
            SqlConnection sql = GetConnection();
            SqlCommand sqlc = new SqlCommand();
            sqlc.Connection = sql;
            sqlc.CommandText = query;
            SqlDataAdapter sd = new SqlDataAdapter(sqlc);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            return ds;
        }
        public void setData(string query, string message) {
            SqlConnection sql = GetConnection();
            SqlCommand sqlc = new SqlCommand();
            sqlc.Connection = sql;
            sql.Open();
            sqlc.CommandText = query;
            sqlc.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show(message, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
