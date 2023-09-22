using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    internal class Deleg
    {
        public delegate int delegateOperation(int a, int b);        

        public int getSum(int a, int b)
        {
            return a + b;
        }

        public int getMulty(int a, int b)
        {
            return a * b;
        }

        public void getConcat(string a, string b)
        {
            Console.WriteLine(a + " " + b);
        }

        public void getConcat2(string a, string b)
        {
            Console.WriteLine(a.ToUpper() + " - " + b.ToUpper());
        }

        public int printOperation(delegateOperation operation, int a, int b)
        {
            var result = operation(a, b);
            Console.WriteLine(result);
            return result;
        }

        public int printOperationFunc(Func<int, int, int> func, int a, int b)
        {
            return func(a, b);
        }


        public void printOperationArray(Func<int, bool> func, params int[] array)
        {
            var result = array.Where(func);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }            
        }

        public void printOperationAction(Action<string, string> act, string a, string b)
        {
            act(a, b);
        }
    }
}
