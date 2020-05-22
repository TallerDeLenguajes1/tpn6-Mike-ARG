using System;

namespace ejercicio2
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
                int aux = 0, opcion;
                float X, Y, resultado;

                Console.WriteLine("Seleccione la operación que desea realizar: ");
                Console.WriteLine("1) Suma\n2) Resta\n3) Multiplicación\n4) División");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nOperación elegida: Suma");
                        Console.WriteLine("Ingrese el primer número a operar: ");
                        X = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número a operar: ");
                        Y = Convert.ToInt32(Console.ReadLine());
                        resultado = X + Y;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("\nOperación elegida: Resta");
                        Console.WriteLine("Ingrese el primer número a operar: ");
                        X = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número a operar: ");
                        Y = Convert.ToInt32(Console.ReadLine());
                        resultado = X - Y;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("\nOperación elegida: Multiplicación");
                        Console.WriteLine("Ingrese el primer número a operar: ");
                        X = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número a operar: ");
                        Y = Convert.ToInt32(Console.ReadLine());
                        resultado = X * Y;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 4:
                        Console.WriteLine("\nOperación elegida: División");
                        Console.WriteLine("Ingrese el primer número a operar: ");
                        X = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número a operar: ");
                        Y = Convert.ToInt32(Console.ReadLine());
                        resultado = X / Y;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                }
        }
    }
}
