using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace WebLapDemo.Models
{
    public class ConnectDataBase 
    {
        SqlConnection con;

        SqlDataAdapter da;

        DataSet ds;

        SqlCommand cmd;

        public void conncet()
        {

            if (con == null)

                con = new SqlConnection("server=DESKTOP-JCD31U1\\NONGLAMCNTT; database=QuanLyAdmin; integrated security = true;");
            
            if (con.State == ConnectionState.Closed)

                con.Open();
        }
        public void disconnect()
        {

            if ((con != null) && (con.State == ConnectionState.Open))

                con.Close();
        }
        public DataSet loadData(string sql)

        {

            conncet();

            da = new SqlDataAdapter(sql, con);

            ds = new DataSet();

            da.Fill(ds);

            disconnect();

            return ds;

        }

        public void ExeCuteNonQuery(string sql)

        {

            conncet();

            cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            disconnect();

        }
    }
}