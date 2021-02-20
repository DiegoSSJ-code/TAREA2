using System;

namespace CARACTER_MAYUS
{
        class Program
        {
            static void Main(string[] args)
            {
                char characther;

                Console.Write("Por favor ingrese un caracter: ");
                characther = Convert.ToChar(Console.Read());

                if (char.IsUpper(characther))
                    Console.WriteLine("\nEl caracter es MAYUSCULA.");
                else
                    Console.WriteLine("\nEl caracter no es MAYUSCULA.");
            }
        }
    }
