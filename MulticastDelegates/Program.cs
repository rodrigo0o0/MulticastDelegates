using MulticastDelegates.Services;
using System;

namespace MulticastDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;
            op(32, 2);
            Console.ReadKey();
        }
    }
}
