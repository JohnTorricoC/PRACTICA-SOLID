using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Hacienda
    {
		public static double CalcularImpuesto(Empleado empleado)
		{
			return empleado.Sueldo * 0.35;
		}

		public static void PagarImpuesto(Empleado empleado)
		{
			double imp = CalcularImpuesto(empleado);
			Console.WriteLine("Se pago {0} en impuestos por parte de {1}", imp, empleado.Nombre);
		}
	}
}
