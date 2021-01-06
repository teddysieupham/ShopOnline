using ProjectMVC5.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebLapDemo.Models
{
    public class DanhSachKhachHang
    {
        private  List<User> list;
        private  ConnectDataBase connect = new ConnectDataBase();

        public static  List<User> geetData()
        {
           DataSet data= connect.loadData("select * from DanhSachKhachHang");

            DataTable dt = data.Tables["DanhSachKhachHang"];
            // In kết quả ra Console
           
            for(int a=0;a<=dt.Rows.Count;a++)
            { 
                    User khachHang = new User();
                    khachHang.setEmail(dt.Rows[a][1]);
                    khachHang.setLastName(dt.Rows[a][2]);
                    khachHang.setPassword(dt.Rows[a][3]);

                list.Add(khachHang);
            }


            return list;
        }

       
    }
}