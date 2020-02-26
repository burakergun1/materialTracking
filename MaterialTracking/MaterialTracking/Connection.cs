using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodOlusturma
{
    class Connection
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABGIL25\SQLEXPRESS;Initial Catalog=Lab;Integrated Security=True");

        public SqlConnection Open()
        {
           con.Open();
            return con;
        }
        public SqlConnection Close()
        {
            con.Close();
            return con;
        }
    }
}
