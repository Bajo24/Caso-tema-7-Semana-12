using System;

namespace Caso_tema_7_Semana_12
{
    internal class Program
    {
        static public void numero_naturales()
        {
            Console.Write("Ingresar numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++)
            {
                S = S + c;
            }
            Console.WriteLine("La suma es: " + S);
        }

        static public int sumaNN_con_recursividad(int N)
        {
            if (N <= 0) 
            {
                return 0;
            }
            return N + sumaNN_con_recursividad(N - 1);
        }

        static public int sumaNP_con_recursividad(int N)
        {
            if (N <= 0) 
            {
                return 0;
            }
           
            if (N % 2 == 0)
            {
                return N + sumaNP_con_recursividad(N - 2);
            }
            else
            {
                return sumaNP_con_recursividad(N - 1);
            }
        }

        static public int Factorial(int N)
        {
            if (N <= 1) 
            {
                return 1;
            }
            return N * Factorial(N - 1);
        }

        static public int exponente_recurvividad(int a, int ex)
        {
            if (ex <= 0) 
            {
                return 1;
            }
            return a * exponente_recurvividad(a, ex - 1);
        }

        static public void Conteo_regresivo(int N)
        {
            if (N < 0)
            {
                return;
            }
            Console.WriteLine(N);
            Conteo_regresivo(N - 1);
        }

        static public int suma_arreglos(int[] numeros, int indice)
        {
            if (indice >= numeros.Length)
            {
                 return 0;
            }
            return numeros[indice] + suma_arreglos(numeros, indice + 1);
        }
            
        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor)
            {
                Console.Clear();
                Console.WriteLine("***********************************");
                Console.WriteLine("\t\tMenu de opciones");
                Console.WriteLine("***********************************");
                Console.WriteLine("[1]. Suma de N numeros naturales");
                Console.WriteLine("[2]. Suma de N numeros naturales con recursividad");
                Console.WriteLine("[3]. Suma de N numeros pares con recursividad");
                Console.WriteLine("[4]. Factorial");
                Console.WriteLine("[5]. Potencia");
                Console.WriteLine("[6]. Conteo regresivo ");
                Console.WriteLine("[7]. Arreglos");
                Console.WriteLine("[8]. Salir");
                Console.WriteLine("***********************************");
                Console.Write("Seleccione una opción: ");

                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numero_naturales();
                        break;
                    case 2:
                        Console.Write("Ingresar numero de N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + sumaNN_con_recursividad(N));
                        break;
                    case 3:
                        Console.Write("Ingresar hasta qué número (N) deseas sumar pares: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de pares es: " + sumaNP_con_recursividad(N1));
                        break;
                    case 4:
                        Console.Write("Ingresar numero de N: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es: " + Factorial(N2));
                        break;
                    case 5:
                        Console.Write("Ingresar base: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Ingresar exponente: ");
                        int ex = int.Parse(Console.ReadLine());
                        Console.WriteLine(a + "^" + ex + "=" + exponente_recurvividad(a, ex));
                        break;
                    case 6:
                        Console.Write("Ingresar número para inicio de conteo: ");
                        int N3 = int.Parse(Console.ReadLine());
                        Conteo_regresivo(N3);
                        break;
                    case 7:
                        int[] numeros = { 10, 15, 20, 25, 30 };
                        Console.WriteLine(("La suma del arreglo es: " + suma_arreglos(numeros, 0)));
                        break;
                    case 8:
                        valor = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                if (valor)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey(); 
                }
            }
        }
    }
}
