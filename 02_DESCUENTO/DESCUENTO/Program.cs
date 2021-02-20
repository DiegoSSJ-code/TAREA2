using System;

namespace DESCUENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            double compra, desc;
            const double porc = 0.20;
            Console.WriteLine("\n¿Cuanto fue el subtotal a pagar?");
            compra = Convert.ToDouble(Console.ReadLine());
            if (compra > 300)
            {
                desc = compra - (compra * porc);
                Console.WriteLine(\n"El total a pagar es de: " + desc);
            }
            else
            {
                Console.WriteLine("\nEl total a pagar es de: " + compra);
            }
        }
    }
}
