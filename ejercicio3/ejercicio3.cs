using System;

namespace ejercicio3
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            float numero, X, Y;
            Console.WriteLine("Ingrese un número: ");
            numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Número ingresado: " + numero);
            
            Console.WriteLine("Valor absoluto del número: " + Math.Abs(numero));
            Console.WriteLine("Cuadrado del número: " + Math.Pow(numero, 2));
            Console.WriteLine("Raíz cuadrada del número: " + Math.Sqrt(numero));
            Console.WriteLine("Seno del número: " + Math.Sin(numero));
            Console.WriteLine("Coseno del número: " + Math.Cos(numero));
            Console.WriteLine("Parte entera del número: " + (int)numero);

            Console.WriteLine("\nSe evaluará, a partir de 2 números, cuál es el máximo y cuál es el mínimo: ");
            
            Console.WriteLine("\nIngrese el primer número: ");
            X = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("\nIngrese el segundo número: ");
            Y = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nMáximo: " + Math.Max(X, Y) + "\nMínimo: " + Math.Min(X, Y));
        }
    }
}
