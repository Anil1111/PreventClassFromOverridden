﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtual
{
    class TestClass
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double x, y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                return x * y;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return PI * x * x;
            }
        }

        class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }

        class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }
            //It will not be called
            public new  double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }

        static void Main()
        {
            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);
            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Here Area will be different from expected \n Here Area of Cylinder = {0:F2}", l.Area());
        }
    }
   
}
