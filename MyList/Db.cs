using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace MyList
{
    internal class Db
    {
        public IEnumerable<Data> getData()
        {
            using (SqlConnection db = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\байбатыровм\\Documents\\testDB.mdf;Integrated Security=True;Connect Timeout=30") )
            {
                return db.Query<Data>("select id, name from city");
            }
        }
    }
    internal class Data
    {
        public int? id { get; set; } 
        public string name { get; set; }
        public Data2 data { get; set; }
    }

    internal class Data2
    {
        public int? id { get; set; }
        public string name { get; set; }
    }

    internal class Data3
    {
        public int? id { get; set; }
        public string name { get; set; }
    }

}
