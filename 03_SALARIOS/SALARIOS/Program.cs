using System;

namespace SALARIOS
{
    class Program
    {
        static void Main(string[] args)
        {
            const int hrs_normales = 16;
            const int hrs_extras = 20;
            int horas, normales, extras;
           
            Console.WriteLine("\n¿Cuántas horas trabajó?");
            horas = Convert.ToInt32(Console.ReadLine());

            if (horas > 40 && horas < 85)
            {
                extras = (horas - 40);
                normales = (horas - extras);

                Console.WriteLine("\t*****CANTIDADES*****");
                Console.WriteLine("Normañes: " + normales);
                Console.WriteLine("Extras: " + extras);
                Console.WriteLine("\t*****PRECIOS*****");
                Console.WriteLine("Normales: " + (hrs_normales * normales));
                Console.WriteLine("Extras: " + (hrs_extras * extras));
                Console.WriteLine("SEMANAL: " + (hrs_extras * extras) + (hrs_normales * normales));
            }
            else if (horas > 0 && horas < 41)
            {
                extras = (horas - 40);
                normales = (horas - extras);
                Console.WriteLine("\nSEMANAL: " + (hrs_normales * normales));
            }
            else
            {
                Console.WriteLine("INGRESE UNA CANTIDAD DE HORAS VALIDA");
            }
        }
    }
}
