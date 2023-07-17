namespace SEP_222_2_.NET
{
    class Student
    {
        public string? lastName { get; set; }
        public string? firstName { get; set; }
    }
    public class Program
    {
        static int byDefault(int x, int y, int z = 0)
        {
            if (z == 0)
                return x + y;
            return x + y + z;
        }
        static int byValue(int x, int y)
        {
            x += 10;
            y += 10;
            return x + y;
        }

        static int byReference(ref int x, ref int y)
        {
            x += 10;
            y += 10;
            return x + y;
        }

        static int byOut(int x, int y, out int z)
        {
            z = x + y;
            return x * y;
        }
        static int byIn(in int x, in int y)
        {
            return x * y;
        }

        static int byArr(int[] arr)
        {
            return 0;
        }

        static int byArrParams(params int[] arr)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            var res = byDefault(10, 20);
            Console.WriteLine(res);
            res = byDefault(10, 20, 30);
            Console.WriteLine(res);

            //int x = 10, y = 20, z;
            //byOut(x, y, out z);
            //Console.WriteLine($"z={z} x={x}, y={y}");

            //int x = 10, y = 20;
            //int res = byReference(ref x, ref y);
            //Console.WriteLine($"res={res} x={x}, y={y}");

            //int res = byValue(x, y);
            //Console.WriteLine($"res={res} x={x}, y={y}");
            #region архив

            //Student student = new Student()
            //{
            //    firstName = "Artem",
            //    lastName = "Kim"
            //};

            //var length = student.lastName != null ? student.lastName.Length.ToString() : "empty";
            //var length = student.lastName?.Length;
            //var length = student.lastName ?? "empty";
            //Console.WriteLine(length);

            //var arr_1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var arr_2 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var arr_3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] arr_4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (var item in arr_1)
            //{
            //    Console.WriteLine(item);
            //}


            //bool? b = null;
            //int? x = null;

            //DateTime dt = DateTime.Now;
            //string s_dt = DateTime.Now.ToString("HH");
            //Console.WriteLine(s_dt);


            //var d = 123456;
            //int i = (int)d;


            //int i = Convert.ToInt32(st);
            //int i = int.Parse(st);

            //const double cPi = 3.14;
            ////int x, y, z;


            //var f = 123.456f;
            //decimal d1 = 123.456m;
            //Console.WriteLine(int.MinValue + " " + int.MaxValue);
            //Console.WriteLine($"{int.MinValue} {int.MaxValue}");
            //Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);


            //if(args.Length == 0)
            //{
            //    Console.WriteLine("No arguments");
            //    return;
            //}
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}
            //Console.Write("Input your name: ");
            //var input = Console.ReadLine();
            //Console.WriteLine($"Hello, {input}");
            #endregion
        }
    }

}
