using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DUNG
{
    internal class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand;//truy van cac cau lenh
        SqlDataReader datareader;//dung de doc du lieu trong bang
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taikhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Conection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                datareader = sqlCommand.ExecuteReader();
                while (datareader.Read())
                {
                    taikhoans.Add(new TaiKhoan(datareader.GetString(0),datareader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taikhoans;

        }
        public void Command(string query)//dung de dky tai khoan
        {
            using (SqlConnection sqlConnection=Conection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}

