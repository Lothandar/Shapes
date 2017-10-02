using System;

namespace shapes
{
    class Triangle
    {
        private double height;
        private double baseLength;

        public Triangle()
        {
            this.height = 1;
            this.baseLength = 1;
        }

        public Triangle(double height,double baseLength)
        {
            this.height = height;
            this.baseLength = baseLength;
        }

        public double Height
        {
            get 
            {
                return height;
            }
            set
            {
                if (value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                height = value;
            }
        }

    public double BaseLength
        {
            get 
            {
                return baseLength;
            }
            set
            {
                if (value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                baseLength = value;
            }
        }

        public double GetPerimeter()
        {
            return (Math.Sqrt(Math.Pow((baseLength * 0.5), 2) + Math.Pow(height,2)))*2 + baseLength ;
        }
        public double GetArea()
        {
            return (height * baseLength) * 0.5;
        }
    
    }
}