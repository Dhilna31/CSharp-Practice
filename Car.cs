using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    //It's internal,which means that it can only be accessed from within the assembly.
    internal class Car
    {

        public static int NumberOfCars = 0;
        //member variable-its a field inside of the class but outside of the methods.
        //private hides the variable from other classes.
        //backing field of the model property "_model".
        private string _model = "";

        private string _brand = "";

       // private bool _isLuxury;

        //Property
        //the below code uses lambada expression
        //to get below code right click on the _model and _brand declared using private then quick refractor option and select encaspulate option and use property.
        public string Model1 { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if(IsLuxury)
                {
                    return _brand + "-luxury Edition";
                }
                else
                {
                    return _brand;
                }

            }
       

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }
                   
        }

        public bool IsLuxury {get; set;}
        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }




        //custom constructor-same as the class name but with no return type.wjen the object is created then the constructor is be instaniated.
        //here we are taking two parameters by the constructor.
        public Car(string model,string brand, bool isLuxury) {
            NumberOfCars++;
            Model1 = model;
            Brand = brand;
           
            Console.WriteLine($"A {Brand} of the model {Model1} has been created");
            IsLuxury = isLuxury;
        }

        public Car()
        {
            NumberOfCars++;
        }

        //methods-are the capabilities of a class.
        public void Drive()
        {
            Console.WriteLine($"I'm a {Model1} and I'm driving");
        }
    }
}
