using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BoxingYUnboxing
{
  class Program
  {
    static void Main(string[] args)
    {
      int numerosDeUnMillon = 1000000;


      Stopwatch prueva1  = new Stopwatch();
      prueva1.Start();
      Stack<int> Pila = new Stack<int>();

      //creo un millon de numeros 
      for (int i = 0; i <= numerosDeUnMillon; i++)
      {
        Pila.Push(i);
      }
      Console.WriteLine(" UN MILLON DE NUMEROS");
      // muestro un millon de numeros
      foreach (Object item in Pila)
      {
        Console.WriteLine(item);
      }
      prueva1.Stop();
      Console.WriteLine("fin de la prueva 1");

      Console.WriteLine();

      Console.WriteLine("comienzo de la prueva 2");


      Stopwatch prueva2 = new Stopwatch();
      prueva2.Start();


      Queue<int> Cola = new Queue<int>();
      // creo un millon de numero
      for (int i = 0; i <= numerosDeUnMillon; i++)
      {
        Cola.Enqueue(i);
      }
      //muestra el un millon de numero
      Console.WriteLine(" UN MILLON DE NUMEROS ");
      foreach (Object items in Cola)
      {
        Console.WriteLine(items);
      }
      prueva2.Stop();
      Console.WriteLine("FIN DE LA PUEVA 2 ");
      Console.WriteLine();
      Console.WriteLine("RESULTADO");
      Console.WriteLine("TIEMPO TARDADO  DE LA PREUEVA 1: " + prueva1.Elapsed.TotalMilliseconds);
      Console.WriteLine("TIEMPO TARDADO DE LA PREUEVA 2 :" + prueva2.Elapsed.TotalMilliseconds);
      Console.WriteLine();
   
      
      Console.WriteLine("GANADOR : PRUEVA 2 ");
    }
  }
}
