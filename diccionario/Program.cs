using System;
using System.Collections.Generic;
namespace diccionario
{
  class Program
  {
    static void Main(string[] args)
    {


      Dictionary<int, Tuple<string, string>> CiudadesDeArgentina = new Dictionary<int, Tuple<string, string>>();


      CiudadesDeArgentina.Add(1, new Tuple<string, string>("Buenos Aires", "La Plata"));
      CiudadesDeArgentina.Add(2, new Tuple<string, string>("Catamarca ", " San Fernando del Valle de Catamarca"));
      CiudadesDeArgentina.Add(3, new Tuple<string, string>(" Chaco ", " Resistencia"));
      CiudadesDeArgentina.Add(4, new Tuple<string, string>("Chubut ", " Rawson"));

      CiudadesDeArgentina.Add(5, new Tuple<string, string>("Córdoba ", " Córdoba"));
      CiudadesDeArgentina.Add(6, new Tuple<string, string>("Corrientes ", "Corrientes"));
      CiudadesDeArgentina.Add(7, new Tuple<string, string>("Entre Ríos", " Paraná"));
      CiudadesDeArgentina.Add(8, new Tuple<string, string>("Formosa ", " Formosa"));
      CiudadesDeArgentina.Add(9, new Tuple<string, string>("Jujuy ", " San Salvador de Jujuy"));
      CiudadesDeArgentina.Add(10, new Tuple<string, string>("La Pampa ", " Santa Rosa"));
      CiudadesDeArgentina.Add(11, new Tuple<string, string>("La Rioja ", " La Rioja"));
      CiudadesDeArgentina.Add(12, new Tuple<string, string>("Mendoza ", " Mendoza"));
      CiudadesDeArgentina.Add(13, new Tuple<string, string>("Misiones ", " Posadas"));
      CiudadesDeArgentina.Add(14, new Tuple<string, string>("Neuquén ", " Neuquén"));
      CiudadesDeArgentina.Add(15, new Tuple<string, string>("Río Negro ", " Viedma"));
      CiudadesDeArgentina.Add(16, new Tuple<string, string>("Salta ", " Salta"));
      CiudadesDeArgentina.Add(17, new Tuple<string, string>("San Juan ", " San Juan"));
      CiudadesDeArgentina.Add(18, new Tuple<string, string>("San Luis ", " San Luis"));
      CiudadesDeArgentina.Add(19, new Tuple<string, string>("Santa Cruz ", " Río Gallegos"));
      CiudadesDeArgentina.Add(20, new Tuple<string, string>("Santa Fe ", " Santa Fe"));
      CiudadesDeArgentina.Add(21, new Tuple<string, string>("Santiago del Estero ", " Santiago del Estero"));
      CiudadesDeArgentina.Add(22, new Tuple<string, string>("Tierra del Fuego, Antártida e Islas del Atlántico Sur ", " Ushuaia"));
      CiudadesDeArgentina.Add(23, new Tuple<string, string>("Tucumán	", " San Miguel De Tucumán"));

      int NUM;
      string linea;
      Console.WriteLine("INGRESE UN NUMERO ENTRE 1 Y 23");
      linea = Console.ReadLine();
      NUM = Convert.ToInt32(linea);
      Console.WriteLine();
      Console.WriteLine(CiudadesDeArgentina[NUM]);
      Console.WriteLine();
    }
  }
}
