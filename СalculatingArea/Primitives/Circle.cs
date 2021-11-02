using System;
using System.Collections.Generic;
using СalculatingArea.Data;

namespace СalculatingArea.Primitives
{
	public class Circle : Primitive
	{
		public Circle(IDictionary<PrimitiveType, double> parametersPrimitive) : base(parametersPrimitive)
		{
		}

		protected override double FigureArea(IDictionary<PrimitiveType, double> parametersPrimitive)
		{
			if(parametersPrimitive.Count != 1 && !parametersPrimitive.ContainsKey(PrimitiveType.Radius))
			{
				throw new Exception("Invalid parameters specified.");
			}
		
			return Math.PI * Math.Pow(parametersPrimitive[PrimitiveType.Radius], 2);
		}
	}
}
