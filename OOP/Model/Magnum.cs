using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    internal class Magnum<T>
    {
        string Name { get; set; }
        T Cost { get; set; }
        string Articul { get; set; }
        public Magnum(string name, T cost, string articul)
        {
            Name = name;
            Cost = cost;
            Articul = articul;
        }
        public void Sell()
        {
            if (Cost is int)
                Console.WriteLine($"Продано: {Name}, артикул: {Articul}, стоимость: {Cost}");
        }
    }

    class MyExport<T> where T : CommonReport
    {
        public MyExport(T t)
        {           
            t.Export();
        }
    }
  
}
