using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labs
{
    class Triangle : Shape
    {
        private double oneSide;

        public Triangle(double p)
        {
            oneSide = p;
            xPos = DataModel.getNewXPos();
            yPos = DataModel.getNewYPos();
        }
        public override double getArea()
        {
            return Math.Pow(oneSide, 2) * (Math.Sqrt(3) / 4);
        }

        public override double getPerimeter()
        {
            return oneSide * 3;
        }

        public override void printData()
        {
            Console.WriteLine();
            Console.WriteLine("My type: " + this.GetType());
            Console.WriteLine("Side of triangle = " + oneSide);
            Console.WriteLine("Area of triangle =  " + getArea());
            Console.WriteLine("Perimeter of triangle =  " + getPerimeter());
            Console.WriteLine("X position = " + xPos);
            Console.WriteLine("Y position = " + yPos);
        }
    }
}
