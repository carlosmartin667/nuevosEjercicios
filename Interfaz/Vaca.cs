using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
  class Vaca :baseAnimal,Hervivoro
  {

    public void comerP(string pasto)
    {
      pasto = "pasto";
    }
    public int litrodeLeche { get; set; }
  }
}
