using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero uno: ");
            short n1 = short.Parse(Console.ReadLine()); //Con esta linea se lleva el código

            Console.WriteLine("Numero dos: ");
            short n2 = short.Parse(Console.ReadLine());

            //Instanciar la clase
            Calculos realizarOperacion = new Calculos(); //Constructor (Calculos() )

            //utilizamos el objeto (metodo aparece con un cubo (morado))
            realizarOperacion.num1 = n1;
            realizarOperacion.num2 = n2;

            //Console.WriteLine(realizarOperacion.num1 + " " + realizarOperacion.num2);
            realizarOperacion.sumar(realizarOperacion.num1, realizarOperacion.num2);
            realizarOperacion.mostrarResultados();
            Console.ReadLine();

        }
    }
}
