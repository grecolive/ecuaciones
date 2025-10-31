using ecuaciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecuaciones.Clases
{
	public class CalculadorCuadratico
	{
		private readonly SolucionadorCuadratico solucionador;
		public CalculadorCuadratico(SolucionadorCuadratico solucionador)
		{
			this.solucionador = solucionador;
		}
		public (double? x1, double? x2, string? mensaje) Calcular(double a, double b, double c)
		{
			return solucionador.ResolverEcuacionCuadratica(a, b, c);
		}
	}
}
