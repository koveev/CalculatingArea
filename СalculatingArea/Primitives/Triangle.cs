using System;
using System.Collections.Generic;
using СalculatingArea.Data;

namespace СalculatingArea.Primitives
{
	public class Triangle : Primitive
	{
		public Triangle(IDictionary<PrimitiveType, double> parametersPrimitive) : base(parametersPrimitive)
		{
		}

		protected override double FigureArea(IDictionary<PrimitiveType, double> parametersPrimitive)
		{
			if(!(parametersPrimitive.Count == 4 
				&& parametersPrimitive.ContainsKey(PrimitiveType.Height)
				&& parametersPrimitive.ContainsKey(PrimitiveType.Width)
				&& parametersPrimitive.ContainsKey(PrimitiveType.LongestSideTriangle)
				&& parametersPrimitive.ContainsKey(PrimitiveType.Radius)))
			{
				throw new Exception("Invalid parameters specified.");
			}

			return parametersPrimitive[PrimitiveType.Radius] 
				* (parametersPrimitive[PrimitiveType.Width] 
				+ parametersPrimitive[PrimitiveType.Height] 
				+ parametersPrimitive[PrimitiveType.LongestSideTriangle]) / 2;
		}

		public bool IsRectangular(IDictionary<PrimitiveType, double> parametersPrimitive)
		{
			if(!(parametersPrimitive.Count == 3
				&& parametersPrimitive.ContainsKey(PrimitiveType.Height)
				&& parametersPrimitive.ContainsKey(PrimitiveType.Width)
				&& parametersPrimitive.ContainsKey(PrimitiveType.LongestSideTriangle)))
			{
				throw new Exception("Invalid parameters specified.");
			}

			return Math.Pow(parametersPrimitive[PrimitiveType.LongestSideTriangle], 2) 
				== Math.Pow(parametersPrimitive[PrimitiveType.Height], 2) 
				+ Math.Pow(parametersPrimitive[PrimitiveType.Width], 2);
		}
	}
}
