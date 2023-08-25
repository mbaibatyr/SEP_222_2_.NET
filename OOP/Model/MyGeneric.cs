using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    internal class MyGeneric
    {
        public void getArrayString(params string[] array)
        {
            Console.WriteLine($"{array[0]}  -  {array[array.Length - 1]}");
        }

        public void getArrayInt(params int[] array)
        {
            Console.WriteLine($"{array[0]}  -  {array[array.Length - 1]}");
        }

        public void getArrayObj(params object[] array)
        {
            Console.WriteLine($"{array[0]}  -  {array[array.Length - 1]}");
        }
    }

    internal class MyGeneric2<T> where T : Data
    {
        public void getArray(params T[] array)
        {
            Console.WriteLine($"{array[0]}  -  {array[array.Length - 1]}");
        }       
    }


    

}
