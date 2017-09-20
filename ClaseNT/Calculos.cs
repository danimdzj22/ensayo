using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNT
{
    class Calculos
    {
        //Atributos (campos: Tipo de dato y modificador de acceso)
        public short num1, num2;

        //Metodo (Estructura orientada a objetos) modificador de acceso (public), retorno(void), nombre(sumar)
        short sumarNumeros = 0;

        public void sumar(short numero1, short numero2)
        {
            sumarNumeros = (short) (numero1 + numero2);
        }

        public void mostrarResultados()
        {
            Console.WriteLine("Total: " + sumarNumeros);
        }

    }
}
