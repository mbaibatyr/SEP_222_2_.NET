namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Db db = new Db();
            //foreach (var item in db.getData()) 
            //{ 
            //    Console.WriteLine(item.id.ToString().Length);
            //}

            List<Data> lst = new List<Data>()
            {
                new Data{id=null, name="Astana"},
                new Data{id=2},
                new Data{id=3, name="Almaty"}
            };

            foreach (var item in lst)
            {
                Console.WriteLine(item?.data?.name);

                if (item.data != null)
                    if (item.data.name != null)
                        Console.WriteLine(item.data.name);

            }


            #region
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

}