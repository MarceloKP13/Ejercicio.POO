using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    public class TiempoCompleto:Empleado
    {
        public double Beneficio {  get; set; } 

        public TiempoCompleto(string nombre, int edad, double salario , double beneficio):base(nombre, edad, salario)
        {
            Beneficio= beneficio;
        }
        
        public override void Informacion()
        {
            base.Informacion();
            Console.WriteLine($"Su beneficio es: {Beneficio}");
            Console.WriteLine($"Su salario anual es de: {SalarioAnual()}");
        }
        public double SalarioAnual()
        {
            return (Salario + Beneficio) * 12;
        }
    }
}
