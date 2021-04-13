using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Empleado : Usuario, IPersona
    {
		private string puesto;
		private double sueldo;
	
		public double Sueldo { get => sueldo; set => sueldo = value; }

		public int NumeroCarnet()
		{
			return 9422860;
		}


		public Empleado(string Nombre, string Puesto, int Edad, double Sueldo)
		{
			nombre = Nombre;
			puesto = Puesto;
			edad = Edad;
			sueldo = Sueldo;
		}

		
		public override string ToString()
		{
			return string.Format("{0},{1},{2},{3},{4}", nombre, puesto, edad, sueldo, NumeroCarnet());
		}
	}
}
