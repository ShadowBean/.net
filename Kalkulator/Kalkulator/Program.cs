using System;
using KalkulatorLib;

namespace Kalkulator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1+2=" + Calculate.Add(1, 2));
            Console.WriteLine("1-2=" + Calculate.Sub(1, 2));
            Console.WriteLine("1*2=" + Calculate.Mul(1, 2));
            Console.WriteLine("1/2=" + Calculate.Div(1, 2));
        }
    }
}
