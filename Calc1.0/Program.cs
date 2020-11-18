using System;
using Clasoperazioni;

namespace Calc1._0
{
    class Program
    {

        static void Main(string[] args)
        {
            double n1 = Class1.Num();
            double n2 = Class1.Num();
            double? risulato = Class1.operazioni(n1,n2);
            Console.Write($"{risulato}");

        }
    }
}
