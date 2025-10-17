using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {

        //In c# const and readonly are two keywords used to define non-modifiable fields,
        //but they differ in trems of when they are initailized and their usage 
        //contexts.Understanding the differences between these two can help in deciding 
        //which one to use based on specific requirements.

        //declaration of field
        public const int NumberOfCorners = 4;
        //declaration of field
        public readonly string Color;

        //Readonly field:A unqiue identifier for each rectangle instance.
        private readonly string _id;

        //const and readonly
        public Rectangle(string color)
        {
            Color = color;
        }

        public void DisplayDetails()
        {

            Console.WriteLine($"Color:{Color}"+
                $"Height: {Height},Area:{Area},Number of Corners:{NumberOfCorners}");
        }
        public double Width { get; set; }
        public double Height { get; set; }

        //computed property
        //if we have only getter method then it will be a readonly property.
        //if we have only setter method then it will be a writeonly property.


        public double Area
        {
            get { return Width * Height; }
        }
    }
}
