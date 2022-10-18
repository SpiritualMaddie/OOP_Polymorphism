using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorphism
{
    class Square : Drawing
    {
        public double Sides { get; set; }                                       // Public class field
        public Square(double aSides)                                            // Constructor with one double parameter
        {
            this.Sides = aSides = 4;                                            // Set class variable to constructor parameter with default value
        }
        public override double Area(double aSides)                              // Method calculating area overrides base class method
        {
            this.Sides = aSides;
            double area = Math.Pow(aSides, 2);
            return area;
        }
        public override void PrintInfo()                                        // Method that prints out info overrides base class method
        {
            Console.WriteLine($"Square area: {Area(Sides)}");
        }
    }
}
