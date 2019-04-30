using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
  class Leon:baseAnimal,Carnivoro
  {
    public void comerC(string carne)
    {
      carne = "carne";
    }
    public int tamaño { get; set; }

  }
}
