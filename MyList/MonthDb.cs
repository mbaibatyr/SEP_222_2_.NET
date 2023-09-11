using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MonthDb
    {
        public IEnumerable<Month> getMonths()
        {
            using (SqlConnection db = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\байбатыровм\\Documents\\testDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                return db.Query<Month>("select id, name from Month");
            }
        }
    }
}
