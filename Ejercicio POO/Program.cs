using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TiempoCompleto empleado1 = new TiempoCompleto("Lenaida Pinza", 40,500.45, 350.10);
            TiempoParcial empleado2 = new TiempoParcial("Marcelo Torres", 22, 254.90, 11, 8.25);

            Console.WriteLine("\tInformacion de Empleado de Tiempo Completo:");
            empleado1.Informacion();

            Console.WriteLine("\n\tInformacion de Empleado de Tiempo Parcial:");
            empleado2.Informacion();

            Console.ReadKey();
        }
    }
}
