using System.Collections.Generic;

namespace StructsApp
{
    public struct Point
    {
        //it's a common practice to make structs imutable by declaring all fields as readonly and providing only get accessors for properties.

        public double Y { get; }
        public double X { get;  }

        //public int Y;
        //public int X;

        public Point(double x,double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx* dx + dy*dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(10,20);
            p1.Display();


            Point p2=p1;//p2 is a copy of p1
            p2.Display();
            p2.X = 25;//changes p2,p1 remains unchanged
            Console.WriteLine("After changing p2.X to 25");
            p1.Display();
            p2.Display();

            bool isEqual = pC1.Equals(pC2);
            Console.WriteLine("is it equal?" + isEqual);

            Console.WriteLine("Now come the class objects");
            PointClass pC1 = new PointClass(1, 2);
            PointClass PC2 = pC1;//pC2 is a reference to the same object as pC1 
            pC1.Display();
            PC2.Display();




            PC2.X = 3;//changes p1.X as well,since p1 and  p2 referenece the same object.

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"Distance between points:{distance:F2}");//F2 means floating two.it can be f3 to get more details.

            Point p3 = p1;
            p1.Display();
            p3.Display();

            Console.ReadKey();
            
        }
    }
}
