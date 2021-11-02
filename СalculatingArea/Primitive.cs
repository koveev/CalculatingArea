using System;
using System.Collections.Generic;
using СalculatingArea.Data;

namespace СalculatingArea
{
	public abstract class Primitive
	{
		private readonly IDictionary<PrimitiveType, double> _parametersPrimitive;

		protected Primitive(IDictionary<PrimitiveType, double> parametersPrimitive)
		{
			_parametersPrimitive = parametersPrimitive;
		}

		public double Calculating()
		{
			ParametersCheck();
			return FigureArea(_parametersPrimitive);
		}

		private void ParametersCheck()
		{
			if(_parametersPrimitive.Count == 0)
			{
				throw new Exception("No parameters specified.");
			}
		}

		protected abstract double FigureArea(IDictionary<PrimitiveType, double> parametersPrimitive);
	}
}
