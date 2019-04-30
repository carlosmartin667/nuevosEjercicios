using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
  class Perro: baseAnimal,Carnivoro,Hervivoro

  {


    public void comerC(string carne)
    {
      carne = "carne";
    }

    public void comerP(string pasto)
    {
      pasto = "pasto";
    }

    public string raza { get; set; }
  }
}
