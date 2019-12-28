using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class Connection
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyBanMatKinh;Integrated Security=True");

        public SqlConnection MoKetNoi()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public SqlConnection DongKetNoi()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
