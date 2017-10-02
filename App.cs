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
            Triangle Triangle2 = new Triangle(3,4);

            Console.WriteLine("Enter the height of the triangle: ");
            try{
            Triangle1.Height = Convert.ToDouble(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("the Height can only take positive number!");
                Console.WriteLine("The value is set to default value: 1");
            }
            Console.WriteLine("Enter the base length of the triangle: ");
            try{
            Triangle1.BaseLength = Convert.ToDouble(Console.ReadLine());
            
            }
            catch(OverflowException)
            {
                Console.WriteLine("the Height can only take positive number!");
                Console.WriteLine("The value is set to default value: 1");
            }


            Console.Write("The area of triangle1 is: ");
            Console.WriteLine( Triangle1.GetArea());
        
        
            Console.Write("The area of triangle2 is: ");
            Console.WriteLine( Triangle2.GetArea());

            Console.Write("The perimeter of the triangle is: ");
            Console.WriteLine( Triangle1.GetPerimeter());
        }
    }
}