using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public double Salario { get; set; }

        public Empleado(string nombre, int edad, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
        }

        public virtual void Informacion()
        {
            Console.WriteLine($"Su nombre es: {Nombre}\n" +
                $"Su edad es: {Edad} años\n" +
                $"Su salario es: ${Salario}");
        }
            
    }
}
