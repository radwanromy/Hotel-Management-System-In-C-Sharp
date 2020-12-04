using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace HMS
{
    class function
    {
        protected MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource = localhost; username=root;password=;database=myHotel; integrated security = True";
            return con;
        }
        public DataSet getData(String query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String message)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" '" + message + "' ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public MySqlDataReader getForCombo(String query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
