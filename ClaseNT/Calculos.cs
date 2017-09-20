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
        short restarNumeros = 0;
        short multiNumeros = 0;
        short diviNumeros = 0;

        public void sumar(short sumar1, short sumar2)
        {
            sumarNumeros = (short) (sumar1 + sumar2);
        }

        public void restar(short restar1, short restar2)
        {
            restarNumeros = (short)(restar1 - restar2);
        }

        /*public void multiplicar(short multi1, short multi2)
        {
            multiNumeros = (short)(multi1 * multi2);
        }

        public void dividir(short divi1, short divi2)
        {
            diviNumeros = (short)(divi1 / divi2);
        }*/

        public void mostrarResultados()
        {
            Console.WriteLine("Total suma: " + sumarNumeros);
            Console.WriteLine("Total resta: " + restarNumeros);
            /*Console.WriteLine("Total multiplicación: " + multiNumeros);
            Console.WriteLine("Total división: " + diviNumeros);*/
        }

    }
}
