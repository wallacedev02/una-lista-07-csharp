using System;
namespace listaVII
{
  class AtividadeIV
  {
      static void Main(string[] args)
      {
         int [] insertion = {1,100,30,50,11,13,5,7,78};

         for( int i = insertion.Length / 2; gap > 0; gap/= 2)
         {
          for(int i = gap; i< insertion;i++)
          {
            int temp = insertion[i];
            int j;

            for(j = i; j >= gap && insertion[j-gap]> temp; -= gap)
            {
              insertion[j]= insertion[j- gap];
            }
            insertion[j]= temp;
          }
         }

         foreach(var num in insertion)
         {
            Console.Write(num + " ")
         }
         Console.WriteLine();
      }
  }
}