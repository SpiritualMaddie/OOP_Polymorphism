using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorphism
{
    class Circle : Drawing 
    {
        public double Radius { get; set; }                                      // Public class field
        public Circle(double aRadius)                                           // Constructor with one double parameter
        {
            this.Radius = aRadius = 8;                                          // Set class variable to constructor parameter with default value
        }
        public override double Area(double aRadius)                             // Method calculating area overrides base class method
        {
            this.Radius = aRadius;
            double pi = 3.14;
            double area = Math.Pow(aRadius, 2) * pi;                            // You can aslo use Math.PI but it gives many more decimals
            return area;
        }
        public override void PrintInfo()                                        // Method that prints out info overrides base class method
        {
            Console.WriteLine($"Circle area: {Area(Radius)}");
        }
    }
}
