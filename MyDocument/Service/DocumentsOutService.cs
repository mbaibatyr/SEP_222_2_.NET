using Dapper;
using MyDocument.Abstract;
using MyDocument.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDocument.Service
{
    internal class DocumentsOutService : IDocumentsOut<DocumentsOut>
    {
        public Status DocumentsOutAdd(DocumentsOut document)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<DocumentsOut> getDocumentsOut(DateTime dtBegin, DateTime dtEnd)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.AppSettings["db"]))
            {
                //return db.Query<DocumentsOut>($"select * from DocumentsOut where DateDocument >= '{dtBegin.ToString("yyyy-MM-dd")}' and  DateDocument <= '{dtEnd.ToString("yyyy-MM-dd")} 23:59:59'");
                return db.Query<DocumentsOut>($"select * from DocumentsOut where DateDocument >= '{dtBegin.ToString("yyyy-MM-dd")}' and  DateDocument <= '{dtEnd.AddDays(1).ToString("yyyy-MM-dd")}'");
            }
        }
    }
}
