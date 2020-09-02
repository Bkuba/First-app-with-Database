using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pracownicy.Model
{
    public class Connect
    {
        public SqlConnection ConnectToDatabase()
        {
            string path = @"Data Source =localhost\KUBASQL;Initial Catalog = BazaCSzarp;User Id = programista; password = JPkurwaelo123";
            var sqlConnection = new SqlConnection(path);
            // lub SqlConnection sqlConnection = new SqlConnection(path);
            sqlConnection.Open();
            return sqlConnection;

        }
    }
}
