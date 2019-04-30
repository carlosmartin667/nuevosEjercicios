using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
  class Perro: baseAnimal,ICarnivoro

  {


    public void comerC(string carne)
    {
      carne = "carne";
    }

  

    public string raza { get; set; }
  }
}
