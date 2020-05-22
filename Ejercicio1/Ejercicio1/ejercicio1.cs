using System;

namespace Ejercicio1
{
    class ejercicio1
    {
        static void Main(string[] args)
        {

            int numero, aux, inverso = 0;

            Console.WriteLine("Ingrese el número a invertir (sólo números mayores a 0): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("ERROR. Ingrese un número mayor a 0: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Número a invertir: " + numero);

            while (numero > 0)
            {
                aux = numero % 10;
                inverso = inverso * 10 + aux;
                numero = numero / 10;
            }
            Console.WriteLine("Número invertido: " + inverso);
        }
    }
}

