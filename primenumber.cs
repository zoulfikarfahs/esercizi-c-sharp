/*Calculate and print all the prime numbers between 1 and 100*/


using System;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;  
              

            //Calculate and display the Prime number  
            Console.WriteLine("Prime Numbers are : "); 
            //qui viene messo il limite dei numeri che devono essere controllati
            for (int i = 2; i <= 100; i++) {
                //questo lupo ci serve per la logica dei numeri primari
                for (int j = 2; j <= 100; j++) { 
                    //e dentro l'IF statement verifichiamo se il numero è primo o no
                    if (i != j && i % j == 0) {  
                        isPrime = false;  
                        break;  
                    }  
                }  

                if (isPrime) {  
                Console.Write("\t" + i);  
            }  
            isPrime = true;  
        }  
        Console.ReadKey();
        }
    }
}
