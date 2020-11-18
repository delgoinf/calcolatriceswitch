using System;
using System.Collections.Generic;
using System.Text;

namespace Clasoperazioni
{
    public class Class1
    {
        public static double Num()
        {
            Console.Write("inserire un numero->  ");
            double n = double.Parse(Console.ReadLine());
            return n;
        }

        public static double? operazioni(double n1, double n2)
        {
            double?risultato = 0;
            Console.WriteLine("immettere: 1-somma,2-sottrazione,3-moltiplicazione,4-divisione");
            Console.WriteLine("digitare operatore deciso");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                case "somma":
                    risultato = n1 + n2;
                    break;
                case "2":
                case "sottrazione":
                    risultato = n1 - n2;
                    break;
                case "3":
                case"moltiplicazione":
                    risultato = n1 * n2;
                    break;
                case "4":
                case "divisione":
                    risultato = n1 / n2;
                    break;
                default:
                    Console.WriteLine("ERRORE");
                    break;
            }
            return risultato;
        }
        
           

    }

}
