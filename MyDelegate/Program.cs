namespace MyDelegate
{
    delegate int DelegateSum(int a, int b);
    internal class Program
    {
        delegate void DelegatePrintHello(string name);
        delegate int DelegateSum(int a, int b);


        static int Sum(int a, int b)
        {
            return a + b;
        }


        static void PrintHello_1(string name)
        {
            Console.WriteLine("Hello " + name);
        }


        static void PrintHello_2(string name, int res)
        {
            Console.WriteLine("Hello " + name + " " + res);
        }

        static void Main(string[] args)
        {
            DelegatePrintHello delegatePrint = new DelegatePrintHello(PrintHello_1);
            DelegateSum delegateSum = new DelegateSum(Sum);
            //delegatePrint("World");
            //Console.WriteLine(delegateSum(12, 13));

            PrintHello_2("My STEP", delegateSum(1,2));

        }
    }
}