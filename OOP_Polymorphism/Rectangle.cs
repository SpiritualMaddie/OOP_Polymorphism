using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorphism
{
    class Rectangle : Drawing
    {
        public double ShortSide { get; set; }                                   // Public class field
        public double LongSide { get; set; }
        public Rectangle(double aShortSide, double aLongSide)                   // Constructor with two double parameters
        {
            this.ShortSide = aShortSide = 10;                                   // Set class variable to constructor parameter with default value
            this.LongSide = aLongSide = 6;
        }
        public double Area(double aShortSide, double aLongeSide)                // Method calculating area
        {
            this.ShortSide = aShortSide;
            this.LongSide = aLongeSide;
            double area = aShortSide * aLongeSide;
            return area;
        }
        public override void PrintInfo()                                        // Method that prints out info overrides base class method
        {
            Console.WriteLine($"Rectangle area: {Area(ShortSide, LongSide)}");
        }
    }
}
