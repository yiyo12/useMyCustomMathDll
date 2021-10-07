using System;
using MyCustomArithmeticLibrary;
namespace UsingMyCustomDll
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyCustomArithmeticLibrary.calculate customDll = new MyCustomArithmeticLibrary.calculate();
            calculate customDll = new calculate();
            var resultSuma =  customDll.sum(3, 5);
            var resultSub = customDll.sub(5, 5);
            Console.WriteLine(resultSuma + "  resultado de substracto  " +  resultSub);
        }
    }
}
