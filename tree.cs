using System;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //per ottenere l'effetto desiderato, cioè la forma dell'albero
            //abbiamo bisogno di un grande numero di spazio che tende a diminuire
            //e di un numero asterischi che parte da uno ma che tende ad aumentare
            int spaces = 6;
            int asterix = 1;


            //in questo lupo controlliamo la grandezza dell'albero
            //cioè il numero delle righe, che in questo caso ho scelto 5
            for (int i = 0; i < 5; i++)
            {
                //per ottenere la forma  giusta abbiamo bisogno dello spazio in ogni riga 
                //che viene definito qui
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");   
                }

                //qui vengono messi gli asterischi
                for (int j = 0; j < asterix; j++)
                {   
                    //qui controlliamo da cosa è formato l'albero, possiamo cambiare il simbolo 
                    //scegliendo un altro
                    Console.Write("* ");
                }
                Console.WriteLine();
                 

                //qui dopo ogni lupo la nuova riga dell'albero 
                //tende ad acquisire più asterichi e meno spazi 
                asterix++;
                spaces--;
            }
        }
    }
}
