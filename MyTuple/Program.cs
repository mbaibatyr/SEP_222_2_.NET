using MyLib;

namespace MyTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (MyDisposeTest myDisposeTest = new MyDisposeTest())
            {
                Console.WriteLine("MyDisposeTest was created");
                myDisposeTest.Dispose
            }

            #region tuple  
            //MyDispose myDispose = new MyDispose();
            //myDispose.ReadFile();
            //CallMyLib.Start();
            //pointer.Start();

            //MyTuple2 myTuple2 = new MyTuple2();
            //var res_1 = myTuple2.getName();
            //Console.WriteLine($"{res_1[0]} {res_1[1]} {res_1[2]} ");
            //var res_2 = myTuple2.getName_2();
            //Console.WriteLine($"{res_2.Split(';')[0]} {res_2.Split(';')[1]} {res_2.Split(';')[2]} ");

            //var res_3 = myTuple2.getName_3();
            //Console.WriteLine($"{res_3.lastName} {res_3.firstName} {res_3.ModdleName} ");

            //var res_4 = myTuple2.getName_4();
            //Console.WriteLine($"{res_4.Item1} {res_4.Item2} {res_4.Item3} ");

            //var res_5 = myTuple2.getName_5();
            //Console.WriteLine($"{res_5.Item1} {res_5.Item2} {res_5.Item3} ");
            #endregion
        }
    }

    class MyTuple2
    {
        private string[] array = { "Иванов", "Петр", "Сергеевич" };
        public string[] getName()
        {
            return array;
        }
        public string getName_2()
        {
            return string.Join(";", array);
        }

        public data getName_3()
        {
            return new data
            {
                lastName = array[0],
                firstName = array[1],
                ModdleName = array[2]
            };
        }

        public (string, string, string) getName_4()
        {
            var result = (array[0], array[1], array[2]);
            return result;
        }

        public Tuple<string, string, string> getName_5()
        {
            Tuple<string, string, string> result =
                new Tuple<string, string, string>(array[0], array[1], array[2]);
            return result;
        }

        public Tuple<string, string, string> getName_6(Tuple<string, string, string> param)
        {
            Tuple<string, string, string> result = param;
            return result;
        }

        public (string, string, string) getName_7((string, string, string) param)
        {
            var result = (param.Item1, param.Item2, param.Item3);
            result.Item1 = "";
            return result;
        }

        public Tuple<string, string, string> getName_8((string, string, string) param)
        {
            return param.ToTuple();
        }

        public Tuple<string, string, string> getName_8(List<(string, string, string)> param)
        {
            return null;
        }
    }

    public class data
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string ModdleName { get; set; }
    }

    public class pointer
    {
        public static void Start()
        {

            //unsafe
            //{
            //    int* Pointer;
            //    int i = 10;
            //    Pointer = &i;
            //    i++;                
            //    Console.WriteLine(*Pointer);
            //}
        }
    }

    class CallMyLib
    {
        public static void Start()
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.getSum(10, 20));
            Console.WriteLine(myClass.getHello("Step"));
            Console.WriteLine(myClass.getHello2("Step2"));
        }
    }

    class MyDispose
    {
        public int id { get; set; }
        public string name { get; set; }

        public MyDispose()
        {
            Console.WriteLine("construct");
        }

        public void ReadFile()
        {
            using (FileStream fs = new FileStream(@"\\share\Shared_Folder\Временные файлы\SEP_222.2\array_1.txt",
                FileMode.Open,
                FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    var content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
        }

        //~MyDispose()
        //{
        //    Console.WriteLine("destruct");
        //}

    }

    class MyDisposeTest : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("MyDisposeTest was disposed");
        }
    }
}