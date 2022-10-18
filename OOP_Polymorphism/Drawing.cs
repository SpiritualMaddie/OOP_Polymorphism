using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorphism
{
    class Drawing
    {
        double area { get; set; }                                               // Private class field
        public virtual double Area(double area)                                 // Method calculating area                                                        
        {
            // This is where calculations 
            // will be made in sub classes
            this.area = area = 0;                                               // Set class variable to constructor parameter with default value
            return area;
        }
        public virtual void PrintInfo()                                         // Method that prints out info overrides base class method
        {
            Console.WriteLine("This is where the area will be shown");
        }
    }
}
