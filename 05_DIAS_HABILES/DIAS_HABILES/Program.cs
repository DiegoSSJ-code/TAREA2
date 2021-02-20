using System;

namespace DIAS_HABILES
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;

            Console.WriteLine("Ingrese un día de la semana: ");
            dia = Console.ReadLine();

            switch (dia)
            {
                case "Lunes":
                    Console.WriteLine("Es un dia habil");
                    break;
                case "Martes":
                    Console.WriteLine("Es un dia habil");
                    break;
                case "Miercoles":
                    Console.WriteLine("Es un dia habil");
                    break;
                case "Jueves":
                    Console.WriteLine("Es un dia habil");
                    break;
                case "Viernes":
                    Console.WriteLine("Es un dia habil");
                    break;
                case "Sabado":
                    Console.WriteLine("No es un dia habil");
                    break;
                case "Domingo":
                    Console.WriteLine("No es un dia habil");
                    break;
                default:
                    Console.WriteLine("Lo siguiente no es un dia valido >>>>  " + dia);
                    break;
            }
        }
    }
}
