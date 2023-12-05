using System;
namespace Excercise4
{
	public class Shape
	{
		public virtual double CalculateArea()
		{
			return 0;
		}
	}

	public class Circle : Shape
	{
		private double radius;
		private double pi = 3.14;

		public Circle(double radius)
		{ 
			this.radius = radius;
		}

        public override double CalculateArea()
        {
			return (pi * radius * radius);
        }
    }
}

