using System.Collections;

namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthDb db = new MonthDb();
            var result = db.getMonths();

            Stack<Month> stack = new Stack<Month>();

            stack.Push(new Month { id = 1, name = "111" });
            stack.Push(new Month { id = 2, name = "222" });
            stack.Push(new Month { id = 3, name = "333" });

            Console.WriteLine(stack.Pop().name);
            Console.WriteLine(stack.Pop().name);


            #region свалка

            //var queue2 = new Queue<Month>(result);

            //Queue<Month> queue = new Queue<Month>();
            //queue.Enqueue(new Month() { id = 1, name = "111" });
            //queue.Enqueue(new Month() { id = 2, name = "222" });
            //queue.Enqueue(new Month() { id = 3, name = "333" });


            //Month m = queue.Dequeue();
            //Console.WriteLine(m.name);
            //m = queue.Dequeue();
            //Console.WriteLine(m.name);
            //m = queue.Dequeue();
            //Console.WriteLine(m.name);
            //m = queue.Dequeue();
            //Console.WriteLine(m.name);

            //Dictionary<int, string> dicMonth = new Dictionary<int, string>();
            //foreach (var item in result)
            //{
            //    dicMonth.Add(item.id, item.name);
            //}

            //dicMonth = result.ToDictionary(x => x.id, x => x.name);



            //Dictionary<int, List<IEnumerable<Month>>> dicMonth2 = 
            //    new Dictionary<int, List<IEnumerable<Month>>>();

            //ArrayList list = new ArrayList();
            //list.Add("1qwe");
            //list.Add(DateTime.Now);
            //list.Add(3);
            //list.Add(new MyCLass4());

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //string[] arMonth = new string[result.Count()];
            //int j = 0;

            ////arMonth = result.Select(z => z.name).ToArray();
            //arMonth = (from z in result
            //          select z.name).ToArray();

            ////foreach (var item in db.getMonths())
            ////{
            ////    arMonth[j++] = item.name;
            ////}


            //for (int i = 0; i < arMonth.Length; i++)
            //{
            //    Console.WriteLine(arMonth[i]);
            //}


            //MyCLass4 my = new MyCLass4();
            //my.Print("sdf");
            //List<Data> lst = new List<Data>()
            //{
            //    new Data{id=null, name="Astana"},
            //    new Data{id=2},
            //    new Data{id=3, name="Almaty"}
            //};

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item?.data?.name);

            //    if (item.data != null)
            //        if (item.data.name != null)
            //            Console.WriteLine(item.data.name);

            //}


            //int? id = null;
            //string st = null;
            //MyClass myClass_1 = null;
            //MyClass myClass_2 = new MyClass();

            //if (st == null)
            //    Console.WriteLine("st is null");

            //if (string.IsNullOrEmpty(st))
            //    Console.WriteLine("st is null");

            //if (st is null)
            //    Console.WriteLine("st is null");
            //;

            //var res = st ?? "STEP";

            //st ??= "STEP";
            //Console.WriteLine(st == null ? "STEP": null);
            //Console.WriteLine(st ??= "STEP");
            //Console.WriteLine(st);

            //int? a = null;
            //int? b = null;
            //var res = a ?? b;
            //var res = myClass_1 ?? myClass_2;
            //string name = string.Empty;
            //Console.WriteLine("hello " + name);
            #endregion
        }
    }

    class MyClass
    {
        public int Id { get; set; }
        public DateTime dt { get; set; }
        public bool bol { get; set; }
        public decimal deci { get; set; }
        public string name { get; set; }

    }

    internal interface ITest<T>
    {
        void Print(T t);
    }

    public class MyCLass4 : ITest<string>
    {
        public void Print(string t)
        {
            throw new NotImplementedException();
        }
    }

    public class MyCLass5 : ITest<DateTime>
    {
        public void Print(DateTime t)
        {
            throw new NotImplementedException();
        }
    }

}
