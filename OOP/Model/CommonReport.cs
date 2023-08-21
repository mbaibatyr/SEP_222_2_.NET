using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace OOP.Model
{
    public abstract class CommonReport
    {
        protected List<ReportData> Data { get; set; }
        protected string Path { get; set; }
        public CommonReport(List<ReportData> data, string path)
        {
            Path = path;
            Data = data;
        }

        //public virtual void Export()
        //{
        //    Console.WriteLine(this.ToString());
        //}

        public abstract void Export();

        protected void Run()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Path)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        protected string[] getArray()
        {
            var array = new string[Data.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = $"{Data[i].Id} {Data[i].Name}";
            }
            return array;
        }
    }

    class CSV : CommonReport
    {
        public CSV(List<ReportData> data, string path) 
            : base(data, path)
        {
        }
        public override void Export()
        {
            Console.WriteLine(this.ToString());
            File.WriteAllLines(Path, getArray());
            Run();
        }
    }

    //class CSV2 : CommonReport
    //{
    //    public CSV2(List<ReportData> data, string path)
    //        : base(data, path)
    //    {
    //    }
    //    public override void Export()
    //    {
    //        base.Export();
    //    }
    //}

    class Excel : CommonReport
    {
        public Excel(List<ReportData> data, string path)
            : base(data, path)
        {
            Data.Add(new ReportData { Id = 4, Name = "Shymkent" });
        }
        sealed public override void Export()
        {
            Console.WriteLine(this.ToString());
            using (XLWorkbook wb = new XLWorkbook())
            {
                var ws = wb.AddWorksheet("report");
                ws.Cell(1, 1).Value = "Id";
                ws.Cell(1, 2).Value = "Name";
                ws.Cell(2, 1).InsertData(Data);
                wb.SaveAs(Path);
            }
            Run();
        }
    }

   

    class Html : CommonReport
    {
        public Html(List<ReportData> data, string path)
            : base(data, path)
        {
        }
        public override void Export()
        {
            Console.WriteLine(this.ToString());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html><body><table border='1'>");
            sb.AppendLine("<tr><td>Id</td><td>Name</td></tr>");
            foreach (var item in Data)
            {
                sb.AppendLine($"<tr><td>{item.Id}</td><td>{item.Name}</td></tr>");
            }

            sb.AppendLine("</table></body></html>");
            File.WriteAllText(Path, sb.ToString());
            Run();
        }
    }

    public class ReportData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
