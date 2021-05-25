using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Dbcon
    {
        private SqlConnection SqlCon;
        public Dbcon()
        {
            SqlCon = new SqlConnection("Data Source=GINGER\\SQLEXPRESS;Initial Catalog=video_game_store;Integrated Security=True");
        }
        public bool UDI(string qry)
        {
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand(qry, SqlCon);
            int res = cmd.ExecuteNonQuery();
            SqlCon.Close();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Search(string qry)
        {
            SqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(qry, SqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlCon.Close();
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
