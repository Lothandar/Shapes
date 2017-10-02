using System;

namespace shapes
{
    class App
    {
        public App()
        {

        }

        public void Run()
        {
            Triangle Triangle1 = new Triangle();

            Console.WriteLine("Enter the height of the triangle: ");
            Triangle1.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the base length of the triangle: ");
            Triangle1.BaseLength = Convert.ToDouble(Console.ReadLine());



            Console.Write("The area of triangle is: ");
            Console.WriteLine( Triangle1.GetArea());
        }
    }
}