using static MyDelegate.Deleg;

namespace MyDelegate
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            Deleg deleg = new Deleg();
            delegateOperation deleg_2 = deleg.getMulty;

            delegateOperation operation_1 = delegate (int a, int b)
            {
                return (a + b) * 2;
            };

            delegateOperation operation_2 = delegate (int a, int b)
            {
                return (a + b) * 10;
            };

            Console.WriteLine(operation_1(10, 30));

            Console.WriteLine(operation_2(10, 30));


            //deleg.printOperationAction(deleg.getConcat, "hello", "step");
            //deleg.printOperationAction(deleg.getConcat2, "hello", "step");

            //Func<int, bool> func = z => z > 2;
            //deleg.printOperationArray(func, 1, 5, 12, 34, 7);

            //var result = deleg.printOperationFunc(deleg.getMulty, 10, 30);
            //Console.WriteLine(result);

            //var result = deleg.printOperation(deleg_2, 10, 30);
            //Console.WriteLine(result);




            //delegateOperation deleg_1 = new delegateOperation(deleg.getSum);
            //Console.WriteLine(deleg_1(10, 20));

            //delegateOperation deleg_2 = deleg.getSum;
            //Console.WriteLine(deleg_2(10, 20));

            //delegateOperation deleg_3 = deleg.getSum;
            //Console.WriteLine(deleg_3.Invoke(10, 20));

        }
    }
}