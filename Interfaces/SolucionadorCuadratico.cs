using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecuaciones.Interfaces
{
	public interface SolucionadorCuadratico
	{
		(double? x1, double? x2, string? mensaje) ResolverEcuacionCuadratica(double a, double b, double c);
	}
}
