using System;

namespace AÑO_BISIESTO
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Ingrese el año");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0 )
            {
                Console.WriteLine("EL AÑO ES BISIESTO");
            }
            else
            {
                Console.WriteLine("EL AÑO NO ES BISIESTO");
            }
        }
    }
}
