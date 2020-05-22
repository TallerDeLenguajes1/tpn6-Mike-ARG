using System;
using System.ComponentModel.DataAnnotations;

namespace ejercicio4
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            string cadena, cadena2, cadena3, cadena4, cadena5;
            int opcion;
            float num1, num2, resultado;
            
            Console.WriteLine("Ingrese una cadena de texto: ");
            cadena = Console.ReadLine();

            cadena2 = cadena.Trim('a'); //Remueve todas las instancias del char 'a' en cadena
            Console.WriteLine("Cadena modificada: " + cadena2);

            Console.WriteLine("Longitud de la cadena: " + cadena.Length);

            Console.WriteLine("\nIngrese una cadena para concatenar: ");
            cadena3 = Console.ReadLine();
            cadena4 = cadena + cadena3;
            Console.WriteLine("Cadena concatenada: " + cadena4);

            cadena5 = cadena.Substring(cadena.IndexOf(" "));

            Console.WriteLine("Seleccione la operación que desea realizar: ");
            Console.WriteLine("1) Suma\n2) Resta\n3) Multiplicación\n4) División");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nOperación elegida: Suma");
                    Console.WriteLine("Ingrese el primer número a operar: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número a operar: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + resultado);
                    break;
                case 2:
                    Console.WriteLine("\nOperación elegida: Resta");
                    Console.WriteLine("Ingrese el primer número a operar: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número a operar: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + resultado);
                    break;
                case 3:
                    Console.WriteLine("\nOperación elegida: Multiplicación");
                    Console.WriteLine("Ingrese el primer número a operar: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número a operar: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + resultado);
                    break;
                case 4:
                    Console.WriteLine("\nOperación elegida: División");
                    Console.WriteLine("Ingrese el primer número a operar: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número a operar: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 / num2;
                    Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + resultado);
                    break;
            }

            foreach(char c in cadena)
            {
                Console.WriteLine(c);
            }

            bool esta = cadena.Contains("hola");

            if (esta)
            {
                Console.WriteLine("La subcadena ingresada se encuentra dentro de la cadena");
            } else
            {
                Console.WriteLine("La subcadena ingresada NO se encuentra dentro de la cadena");
            }

            string cadMay = cadena.ToUpper();
            string cadMin = cadena.ToLower();

            Console.WriteLine("\nIngrese una nueva cadena: ");
            string nuevaCadena = Console.ReadLine();

            if (string.Compare(cadena, nuevaCadena) == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            } else
            {
                Console.WriteLine("Las cadenas no son iguales");
            }

            Console.WriteLine("Ingrese otra cadena: ");
            string cad2 = Console.ReadLine();
            Console.WriteLine("Ingrese el caracter que dividirá la cadena: ");
            char caract = Convert.ToChar((Console.ReadLine()));
            Console.WriteLine("Cadena separada: " +cad2.Split(caract));

        }
    }
}
