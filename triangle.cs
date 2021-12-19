
/*Calculate the Tartaglia's triangle up to row n, where n is a number inserted by the user.*/

using System;

namespace Tartaglia_s_triangle
{
    class Program
    {
        static void Main(string[] args)
        { 
            //qui ho definito tutti i variabili che mi servono
            int no_row,c=1,blk;

            //nel primo lupo ho definito io il numero minimo di qui serve partire 
            //ma per il numero massimo viene chieste allutente di sceglierlo
            Console.Write("inserisci il numero delle righe: ");
            //siccome tutti gli input in dall'utente hanno una datatype string
            //ho messo un method per convertirlo in int
            no_row = Convert.ToInt32(Console.ReadLine());	
            for(int i=0;i<no_row;i++)
            {   
                //in questo lupo bviene definito lo spazio per ottenere la forma corretta
                for(blk=1;blk<=no_row-i;blk++)
                  Console.Write("  ");

                  //qui viene fatto il lupo assegnando il valore di i e j alla formula sotto per formare il triangolo
                  for(int j=0;j<=i;j++)
                  {
                    if (j==0||i==0)
                    c=1;
                    else
                    c=c*(i-j+1)/j;
                    Console.Write("{0}   ",c);
                   }
                   Console.Write("\n");
                }
            }
    }
}
