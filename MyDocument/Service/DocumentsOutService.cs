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
            using (SqlConnection db = new SqlConnection(ConfigurationManager.AppSettings["db"]))
            {
                try
                {
                    string sql = $@"insert into DocumentsOut 
                                (NameDocument, InitiatePerson, Notes, ScanFileName)
                                values (N'{document.NameDocument}',
                                        N'{document.InitiatePerson}',
                                        N'{document.Notes}',
                                        N'{document.ScanFileName}')";

                    db.Execute(sql);
                    return Status.OK;
                }
                catch
                {
                    return Status.ERROR;
                }
            }
        }

        public Status DocumentsOutDelete(string id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.AppSettings["db"]))
            {
                try
                {
                    string sql = $@"delete from DocumentsOut 
                                    where id = {id}";

                    db.Execute(sql);
                    return Status.OK;
                }
                catch
                {
                    return Status.ERROR;
                }
            }
        }

        public Status DocumentsOutEdit(DocumentsOut document)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.AppSettings["db"]))
            {
                try
                {
                    string sql = $@"update DocumentsOut 
                                set NameDocument = N'{document.NameDocument}', 
                                    InitiatePerson = N'{document.InitiatePerson}',
                                    Notes = N'{document.Notes}'
                                    where id = {document.Id}";

                    db.Execute(sql);
                    return Status.OK;
                }
                catch
                {
                    return Status.ERROR;
                }
            }
        }

        public IEnumerable<DocumentsOut> getDocumentsOut(DateTime dtBegin, DateTime dtEnd)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.AppSettings["db"]))
            {
                //return db.Query<DocumentsOut>($"select * from DocumentsOut where DateDocument >= '{dtBegin.ToString("yyyy-MM-dd")}' and  DateDocument <= '{dtEnd.ToString("yyyy-MM-dd")} 23:59:59'");
                return db.Query<DocumentsOut>($"select * from DocumentsOut where DateDocument >= '{dtBegin.ToString("yyyy-MM-dd")}' and  DateDocument <= '{dtEnd.AddDays(1).ToString("yyyy-MM-dd")}'");
            }
        }

        public DocumentsOut getDocumentsOutById(string id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.AppSettings["db"]))
            {                
                return db.Query<DocumentsOut>($"select * from DocumentsOut where id = {id}").FirstOrDefault();
            }
        }
    }
}
