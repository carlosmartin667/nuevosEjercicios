using System;
using System.Collections;


namespace colaYpilas
{
  class Program
  {
    static void Main(string[] args)
    {
      string palabra;
      int numero;

      //pilas con numeros
      Stack miPila = new Stack();
      miPila.Push(0);
      miPila.Push(1);
      miPila.Push(2);
      miPila.Push(3);
      miPila.Push(4);
      miPila.Push(5);
      miPila.Push(6);
      miPila.Push(7);
      miPila.Push(8);
      miPila.Push(9);

      for (byte i = 0; i < 10; i++)
      {
        numero = (int)miPila.Pop();
        Console.WriteLine(numero);
      }


      // cola con numeros
      Queue cola = new Queue();
      cola.Enqueue(0);
      cola.Enqueue(1);
      cola.Enqueue(2);
      cola.Enqueue(3);
      cola.Enqueue(4);
      cola.Enqueue(5);
      cola.Enqueue(6);
      cola.Enqueue(7);
      cola.Enqueue(8);
      cola.Enqueue(9);
      Console.WriteLine();
      for (int i = 0; i < 10; i++)
      {
        numero = (int)cola.Dequeue();
        Console.WriteLine(numero);
      }

      //pila de palabras
      Stack PilaPalabras = new Stack();
      PilaPalabras.Push("hola");
      PilaPalabras.Push("como");
      PilaPalabras.Push("estas");
      PilaPalabras.Push("todo");
      PilaPalabras.Push("bien");
      PilaPalabras.Push("nos");
      PilaPalabras.Push("vemos");
      PilaPalabras.Push("luego");
      PilaPalabras.Push("chau");
      PilaPalabras.Push("adios!");
      Console.WriteLine();
      for (int i = 0; i < 10; i++)
      {
        palabra = (string)PilaPalabras.Pop();
        Console.WriteLine( palabra );
      }
      //cola de palaras
      Queue colaPalabras = new Queue();
      colaPalabras.Enqueue("hola");
     colaPalabras.Enqueue("como");
     colaPalabras.Enqueue("estas");
     colaPalabras.Enqueue("todo");
     colaPalabras.Enqueue("bien");
     colaPalabras.Enqueue("nos");
     colaPalabras.Enqueue("vemos");
     colaPalabras.Enqueue("luego");
     colaPalabras.Enqueue("chau");
     colaPalabras.Enqueue("adios");
      Console.WriteLine();
      for (int i = 0; i < 10; i++)
      {
        palabra = (string)colaPalabras.Dequeue();
        Console.WriteLine( palabra );
      }
      Console.WriteLine();






    }
  }
}
