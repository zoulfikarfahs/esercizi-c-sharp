using System;

namespace primeNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
             
             //in questo loop specifichiamo i margini
            for(int i = 2; i<=100;i++)
            {
                bool isPrimeNumber = true;
                //in questo loop mettiamo la logica 
                //per controllare se è prime number o no
                for(int j=2; j<i; j++ )
                {
                     if(i % j == 0)
                    {
                         isPrimeNumber = false;
                         break;

                    }
                }
               if(isPrimeNumber)
               {
                   Console.Write(i + "  ");
               }
                

            } 
        }

        
    }
}
