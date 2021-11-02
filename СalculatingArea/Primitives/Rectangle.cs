using System;
using System.Collections.Generic;
using СalculatingArea.Data;

namespace СalculatingArea.Primitives
{
	public class Rectangle : Primitive
	{
		public Rectangle(IDictionary<PrimitiveType, double> parametersPrimitive) : base(parametersPrimitive)
		{
		}

		protected override double FigureArea(IDictionary<PrimitiveType, double> parametersPrimitive)
		{
			if(parametersPrimitive.Count != 2 && !parametersPrimitive.ContainsKey(PrimitiveType.Height) && !parametersPrimitive.ContainsKey(PrimitiveType.Width))
			{
				throw new Exception("Invalid parameters specified.");
			}

			return parametersPrimitive[PrimitiveType.Height] * parametersPrimitive[PrimitiveType.Width];
		}
	}
}
