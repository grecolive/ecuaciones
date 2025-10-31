using ecuaciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecuaciones.Clases
{
	public class EcuacionCuadratica : SolucionadorCuadratico
	{
		public (double? x1, double? x2, string? mensaje) ResolverEcuacionCuadratica(double a, double b, double c)
		{

			// Implementación del método para resolver la ecuación cuadrática ax^2 + bx + c = 0
			if (a == 0)
				return (null, null, "No es una ecuación cuadrática (a no puede ser 0)");
			
			double discriminante = (Math.Pow(b,2)) - 4 * a * c;

			if (discriminante < 0)
				return (null, null, "No hay soluciones reales");

			double raizDiscrminate = Math.Sqrt(discriminante);
			double x1 = (-b + raizDiscrminate) / (2 * a);
			double x2 = (-b - raizDiscrminate) / (2 * a);

			return (x1, x2, $"Soluciones Encontradas\n \nX1 = {x1}\nX2 = {x2}");

		}
	}
}
