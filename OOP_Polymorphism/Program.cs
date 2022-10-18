using System;

namespace OOP_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing square = new Square(5);                                     // Creating object from Drawing class that points to Square class
            Drawing rectangle = new Rectangle(3, 5);                           
            Drawing circle = new Circle(9);

            square.PrintInfo();                                                 // Calls method that prints info (the area of that shape)
            rectangle.PrintInfo();
            circle.PrintInfo();

            Console.ReadKey();                                                  // Holds the program open until user press any key
        }
    }
}
