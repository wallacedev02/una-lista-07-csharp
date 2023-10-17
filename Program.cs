using System;
using System.Text.Json.Serialization;
namespace listaVII
{
  class AtividadeIII
  {
      static void Main(string[] args)
      {
        int [] insertion = {1,100,30,50,11,13,5,7,78};

        for(int i = 1; i < insertion.Length;i++)
        {
          int key = insertion[i];
          int j = i-1;

          while (j >= 0 && insertion[j]> key)
          {
            insertion[j+1] = insertion[j];
            j--;
          }
          insertion[j+1]=key;
        }
      foreach( var num in insertion)
      {
        Console.Write(num + " ");
      }  
      Console.WriteLine();  
      }
  }
}

