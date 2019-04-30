using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
  class Leon:baseAnimal,ICarnivoro
  {
    public void comerC(string carne)
    {
      carne = "carne";
    }
    public int tamaño { get; set; }

  }
}
