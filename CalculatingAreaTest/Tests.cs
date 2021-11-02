using NUnit.Framework;

using System.Collections.Generic;

using ÑalculatingArea.Data;
using ÑalculatingArea.Primitives;

namespace CalculatingAreaTest
{
	public class Tests
	{
		[Test]
		public void CircleTest()
		{
			var expecting = 19.634954084936208;
			var circle = new Dictionary<PrimitiveType, double>()
			{
				{PrimitiveType.Radius, 2.5D }
			};

			Assert.AreEqual(expecting, new Circle(circle).Calculating());
		}

		[Test]
		public void RectangleTest()
		{
			var expecting = 100;
			var rectangle = new Dictionary<PrimitiveType, double>()
			{
				{PrimitiveType.Height, 10D },
				{PrimitiveType.Width, 10D }
			};

			Assert.AreEqual(expecting, new Rectangle(rectangle).Calculating());
		}

		[Test]
		public void TriangleTest()
		{
			var expecting = 45;
			var triangle = new Dictionary<PrimitiveType, double>()
			{
				{PrimitiveType.Radius, 6D },
				{PrimitiveType.Height, 5D },
				{PrimitiveType.Width, 3D },
				{PrimitiveType.LongestSideTriangle, 7D }
			};

			Assert.AreEqual(expecting, new Triangle(triangle).Calculating());
		}

		[Test]
		public void AngleOfTriangleTest()
		{
			var expecting = true;
			var triangle = new Dictionary<PrimitiveType, double>()
			{
				{PrimitiveType.Height, 2.9999999999999996},
				{PrimitiveType.Width, 2.9999999999999996 },
				{PrimitiveType.LongestSideTriangle, 4.242640687119285 }
			};

			Assert.AreEqual(expecting, new Triangle(triangle).IsRectangular(triangle));
		}
	}
}