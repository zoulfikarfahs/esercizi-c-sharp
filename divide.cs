
/*Print all the numbers divisible by 5 or 7, from 1 to 100.*/
using System;

namespace dividedBy5or7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("i numeri divisibili con 5 o 7 sono: ");
            //qui faccaimo un lupo che ci serve per mettere dei margini 
            //(minimi e massimi)  per le serie di numeri che vogliamo controllare
            for (int i=1;i<=100;i++)
            {    
                //l'IF statement ci aiuta a verificare se questi numeri scelti
                //sono divisibili su 5 o su 7
                if(i%5==0 || i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
