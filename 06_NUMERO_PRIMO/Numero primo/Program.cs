using System;

namespace Numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, contador = 0;
            Console.WriteLine("Digite un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine("No es un numero primo ");
            }
            else
            {
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador <= 2)
                {
                    Console.WriteLine("No es un numero primo ");
                }
                else
                {
                    Console.WriteLine("Es un numero primo ");
                }

            }
        }
    }
}
