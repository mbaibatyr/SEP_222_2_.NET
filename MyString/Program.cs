using System.Text;
using System.Text.RegularExpressions;

namespace MyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //DemoString demo = new DemoString();
            //Console.WriteLine(demo.S3(""));
            //demo.S4("");  
            string st = null;            
        }


    }

    class DemoString
    {
        public string S1(string Name)
        {
            //return "Hello " + Name;
            //return $"Hello {Name}";
            return string.Format("Hello {0}  {1}", Name, Name);
        }

        public string S2(string Name) => "Hello " + Name;

        public string S3(string Name)
        {
            //string result = "";
            //if (result == null || result == "")
            //    ;

            //if (string.IsNullOrEmpty(result))
            //    ;
            //if (string.IsNullOrWhiteSpace(result))
            //    ;

            //var result2 = new char[] { 's', 't', 'e', 'p' };
            //result = result2.ToString();
            ////"hello step"
            //return result;

            string st = "qwe_step@mail.ru";
            //var res = st.Length;
            //st.Replace("@mail.ru", "").Replace("qwe_", "");
            //return st.Substring(4, 4);
            //return st.StartsWith("a").ToString();
            //return st.EndsWith("ru").ToString();
            //return st.IndexOf("@").ToString();
            //return st.CompareTo("qwe_step@mail.ru").ToString();
            //st = "qwe;asd;zxc";

            var array = st.Split('@');
            //return string.Join(";", array);

            string sTemp = null;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                if (1 == 1)
                    //sTemp += "sdf";
                    sb.AppendLine("sdf");
            }
            return sb.ToString();
        }

        public void S4(string Name)
        {
            string phoneNumber = "+1(876)-234-12-98";
            string pattern = @"\D";            
            Regex regex = new Regex(pattern);
            string result = regex.Replace(phoneNumber, "");
            Console.WriteLine(result);  // 18762341298 
        }

        public DateTime FirstDateMonth(DateTime dt)
        {
           
            //DateTime dtCurrent = DateTime.Now.Date.Add(-2);
            //DateTime dtPrev = new DateTime(2000, 1, 1);
            ////Console.WriteLine(dt.ToString("dd.MM.yyyy"));
            //var diff = dtCurrent - dtPrev;
            //Console.WriteLine(diff.TotalHours);
            return DateTime.Now;

        }

    }
}
