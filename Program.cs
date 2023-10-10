using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string modelo, marca, NumeroTelefonico, estado;
            int CodigoOperador;

            Telefono t1 = new Telefono("14", "Iphone");
            Telefono t2 = new Telefono("Nuevo");

            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("Fulanito"));
            Console.WriteLine("Elija la opcion 1, 2 o 3 caso contrario ingresar cero");
            t1.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Opcion elegida " +  t1.CodigoOperador);
            Console.WriteLine("El telefono es un " + t1.getMarca + " Modelo " + t1.getModelo); 
            Console.WriteLine(t2.Estado);

            
            
            Console.ReadKey();


        }
    }
}
