﻿using Newtonsoft.Json;
using OOP.Model;

namespace OOP
{
    internal class Program
    {

        static void Jshon()
        {
            Console.WriteLine("Hello, World!");
            string jsonString = @"{'status':'success','data':[{'id':1,'employee_name':'Tiger Nixon','employee_salary':320800,'employee_age':61,'profile_image':''},{'id':2,'employee_name':'Garrett Winters','employee_salary':170750,'employee_age':63,'profile_image':''},{'id':3,'employee_name':'Ashton Cox','employee_salary':86000,'employee_age':66,'profile_image':''},{'id':4,'employee_name':'Cedric Kelly','employee_salary':433060,'employee_age':22,'profile_image':''},{'id':5,'employee_name':'Airi Satou','employee_salary':162700,'employee_age':33,'profile_image':''},{'id':6,'employee_name':'Brielle Williamson','employee_salary':372000,'employee_age':61,'profile_image':''},{'id':7,'employee_name':'Herrod Chandler','employee_salary':137500,'employee_age':59,'profile_image':''},{'id':8,'employee_name':'Rhona Davidson','employee_salary':327900,'employee_age':55,'profile_image':''},{'id':9,'employee_name':'Colleen Hurst','employee_salary':205500,'employee_age':39,'profile_image':''},{'id':10,'employee_name':'Sonya Frost','employee_salary':103600,'employee_age':23,'profile_image':''},{'id':11,'employee_name':'Jena Gaines','employee_salary':90560,'employee_age':30,'profile_image':''},{'id':12,'employee_name':'Quinn Flynn','employee_salary':342000,'employee_age':22,'profile_image':''},{'id':13,'employee_name':'Charde Marshall','employee_salary':470600,'employee_age':36,'profile_image':''},{'id':14,'employee_name':'Haley Kennedy','employee_salary':313500,'employee_age':43,'profile_image':''},{'id':15,'employee_name':'Tatyana Fitzpatrick','employee_salary':385750,'employee_age':19,'profile_image':''},{'id':16,'employee_name':'Michael Silva','employee_salary':198500,'employee_age':66,'profile_image':''},{'id':17,'employee_name':'Paul Byrd','employee_salary':725000,'employee_age':64,'profile_image':''},{'id':18,'employee_name':'Gloria Little','employee_salary':237500,'employee_age':59,'profile_image':''},{'id':19,'employee_name':'Bradley Greer','employee_salary':132000,'employee_age':41,'profile_image':''},{'id':20,'employee_name':'Dai Rios','employee_salary':217500,'employee_age':35,'profile_image':''},{'id':21,'employee_name':'Jenette Caldwell','employee_salary':345000,'employee_age':30,'profile_image':''},{'id':22,'employee_name':'Yuri Berry','employee_salary':675000,'employee_age':40,'profile_image':''},{'id':23,'employee_name':'Caesar Vance','employee_salary':106450,'employee_age':21,'profile_image':''},{'id':24,'employee_name':'Doris Wilder','employee_salary':85600,'employee_age':23,'profile_image':''}],'message':'Successfully! All records has been fetched.'}";
            Employees employees = JsonConvert.DeserializeObject<Employees>(jsonString);
            foreach (Data item in employees.data)
            {
                Console.WriteLine($"{item.employee_name}  {item.employee_salary}");
            }
        }
        static void Main(string[] args)
        {

            Data data = new Data();
            Data data2 = null;
            //List<Data> lst = new List<Data>();
            //lst.Add(new Data { id = 1 });
            //lst.Add(new Data { id = 2 });

            Employees employees = new Employees();
            List <object> lst = new List<object>()
            {
                new Data { id = 1 },
                new Data { id = 2 },
                data,
                data2,
                employees
            };

            foreach (var item in lst)
            {
                if(item is Data)
                {
                    var id = (item as Data).id;                   

                }
            }

            //MyGeneric myGeneric = new MyGeneric();
            //myGeneric.getArrayInt(1,2,3,4,5);


            //MyGeneric2<int> myGeneric2 = new MyGeneric2<int>();
            //var array = new int[] { 1, 2, 3, 4, 5 };
            //myGeneric2.getArray(34,45,56);

            //MyGeneric2<Data> myGeneric3 = new MyGeneric2<Data>();
            //Data data1 = new Data();
            //Data data2 = new Data();
            //myGeneric3.getArray(data1, data2);

            //List<ReportData> data = new List<ReportData>()
            //{
            //    new ReportData() {Id=1, Name="Almaty" },
            //    new ReportData() {Id=2, Name="Astana" },
            //    new ReportData() {Id=3, Name="Aktobe" }
            //};

            //t = new T(data, @"C:\Temp\123.csv");
            //CSV csv = new CSV(data, @"C:\Temp\123.csv");
            //csv.Export();

            //Excel excel = new Excel(data, @"C:\Temp\123.xlsx");
            //excel.Export();

            //Html html = new Html(data, @"C:\Temp\123.html");
            //html.Export();


            //MyExport<CSV> csv = new MyExport<CSV>
            //    (
            //        new CSV(data, @"C:\Temp\123.csv")
            //    );

            //MyExport<Excel> excel = new MyExport<Excel>
            //    (
            //        new Excel(data, @"C:\Temp\123.xlsx")
            //    );

            //Magnum<int> magnum = new Magnum<int>("Батон", 250, "123456");
            //magnum.Sell();

            //Magnum<float> magnum2 = new Magnum<float>("СНикерс", 300.15f, "89898989");
            //magnum2.Sell();

            //Magnum<string> magnum3 = new Magnum<string>("Аппорт", "закончились, цена = 0", "3213232");
            //magnum3.Sell();

            #region  OOP
            //List<ReportData> data = new List<ReportData>()
            //{
            //    new ReportData() {Id=1, Name="Almaty" },
            //    new ReportData() {Id=2, Name="Astana" },
            //    new ReportData() {Id=3, Name="Aktobe" }
            //};

            //CSV csv = new CSV(data, @"C:\Temp\123.csv");
            //csv.Export();

            //Excel excel = new Excel(data, @"C:\Temp\123.xlsx");
            //excel.Export();

            //Html html = new Html(data, @"C:\Temp\123.html");
            //html.Export();

            //CommonReport report = new CommonReport(data, @"C:\Temp\123.csv");
            //report.Export();

            //CSV2 cSV2 = new CSV2(data, @"C:\Temp\123.csv");
            //cSV2.Export();
            #endregion
        }
    }
}