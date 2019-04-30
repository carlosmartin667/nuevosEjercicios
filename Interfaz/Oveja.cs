using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
  class Oveja : baseAnimal,Hervivoro
  {

    public void comerP(string pasto)
    {
      pasto = "pasto";
    }

    public String pelaje { get; set; }
  }
}
