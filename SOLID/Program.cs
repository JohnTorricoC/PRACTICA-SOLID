using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juan", "Programador", 23, 18000);
            Console.WriteLine(empleado);
            Console.WriteLine("Impuesto a pagar: " + Hacienda.CalcularImpuesto(empleado));
            Hacienda.PagarImpuesto(empleado);
        }
    }
}
