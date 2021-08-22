using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesAEA_Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            int a,b;
            float c,d;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Conversor de temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                
                switch (opcion)
                {
                    case "1"://Suma()
                        Console.WriteLine("\nSUMA\n");
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2"://Raiz()
                        Console.WriteLine("\nRAIZ\n");
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3"://Resta()
                        Console.WriteLine("\nRESTA\n");
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;
                    case "4"://Multiplicación()
                        Console.WriteLine("\nMULTIPLICACIÓN\n");
                        Console.WriteLine("Ingrese el primer número");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", c, d, Multiplicacion(c, d));
                        Console.ReadKey();
                        break;
                    case "5"://Division()
                        Console.WriteLine("\nDIVISION\n");
                        Console.WriteLine("Ingrese el primer número");
                        c = (float)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        d = (float)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", c, d, Division(c, d));
                        Console.ReadKey();
                        break;
                    case "6"://Primos()
                        Console.WriteLine("\nPRIMOS\n");
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7"://Conversor()
                        Console.WriteLine("\nCONVERSOR DE TEMPERATURA\n");
                        Console.WriteLine("[1] Centigrados a Fahrenheit (C° -> F°)");
                        Console.WriteLine("[2] Fahrenheit a Centigrados (F° -> C°)");
                        opcion = Console.ReadLine();
                        switch (opcion)
                        {
                            case "1":
                                Console.WriteLine("\nC° -> F°\n");
                                Console.WriteLine("Ingrese la temperatura en C°");
                                c = (float)Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} °C es igual a {1} °F", c, Temperatura1(c));
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.WriteLine("\nF° -> C°\n");
                                Console.WriteLine("Ingrese la temperatura en F°");
                                c = (float)Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} °F es igual a {1} °C", c, Temperatura2(c));
                                Console.ReadKey();
                                break;
                        }
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        static int Suma( int a , int b)
        {
            return a + b;
        }

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static float Multiplicacion(float c, float d)
        {
            return c * d;
        }

        static float Division(float c, float d)
        {
            return c / d;
        }

        static void Primos()
        {
            int n = 2;
            int p = 1;
            while (p <= 10)
            {
                Boolean primo = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo)
                {
                    Console.WriteLine(n);
                    p++;
                }
                n++;
            }
        }

        static float Temperatura1(float cel)
        {
            float far;
            far = ((cel * 9) / 5) + 32;
            return far;
        }

        static float Temperatura2(float far)
        {
            float cel;
            cel = (5 * (far - 32)) / 9;
            return cel;
        }

    }
}
