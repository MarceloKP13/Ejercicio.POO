using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    public class TiempoParcial : Empleado
    {
        public int HorasTrabajo { get; set; }
        public double PagoHoras { get; set; }
        public TiempoParcial(string nombre, int edad, double salario, int horasTrabajo, double pagoHoras) : base(nombre, edad, salario)
        {
            HorasTrabajo = horasTrabajo;
            PagoHoras = pagoHoras;
        }

        public override void Informacion()
        {
            base.Informacion();
            Console.WriteLine($"Sus horas EXTRAS trabajadas son: {HorasTrabajo}");
            Console.WriteLine($"Su Tasa de Pago por Hora es: {PagoHoras}");
            Console.WriteLine($"Salario Mensual es: {SalarioMensual()}");
        }
        public double SalarioMensual()
        {
            return (HorasTrabajo * PagoHoras) + Salario;
        }
    }
}
