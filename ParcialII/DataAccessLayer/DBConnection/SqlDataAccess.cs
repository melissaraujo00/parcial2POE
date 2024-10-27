using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DBConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=DESKTOP-JDM7JV2\\MSSQLSERVER01;Initial Catalog=SuperMarket;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection( _connectionString );
        }
    }
}
