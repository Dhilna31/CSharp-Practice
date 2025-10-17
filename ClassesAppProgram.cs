namespace ClassesApp
{
    //access modifier internal
    internal class Program
    {
        static void Main(string[] args)
        {
            //const and readonly
            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("Blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();


            //Id and readonly Example
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("Dhilna David");
            Customer customer3 = new Customer();

            customer1.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();

            customer3.Password = "1234dhilna@56";



            //static fields example
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);

            ////accessing the public static varaible NumberOfCars of the cars.
            Console.WriteLine("Number of cars produced" + Car.NumberOfCars);


            //creating an object of the class car.
            //creating an instance of the class car.
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("I7", "bmw", true);



            //GETTING BRAND
            Console.WriteLine("Brand is" + audi.Brand);
            Console.WriteLine("Brand is" + bmw.Brand);
            //new keyword-allocates memory space for the car object. 


            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Car myBmw = new Car("i7", "Bmw", true);
            myBmw.Drive();




            Customer dhilna = new Customer("Dhilna");
            Customer david = new Customer("David", "Menachery", "9567903288");


            Console.WriteLine("Name of the customer is" + dhilna.Name);
            //Default customer with no arguments given
            Customer myCustomer = new Customer();


            myCustomer.SetDetails("David", "Menachery 2", "9446723288");

            Console.WriteLine("MyCustomer is: " + myCustomer.Name + "and he lives in " + dhilna.Address);

            Console.WriteLine("Please enter the customers Name");
            myCustomer.Name = Console.ReadLine();
            Console.WriteLine("Details about customer: " + myCustomer.Name);

            //optional parameters
            //static method example
            Customer myCustomer = new Customer();
            ////The DoSomeCustomerStuff method is static and cannot be called on Objects.
            myCustomer.SetDetails("Riya", "Menachery 3");

            Customer.DoSomeCustomerStuff();

            MyMethod();

            Customer customer1 = new Customer("David");
            Console.WriteLine("Contactnumber of david is: " + customer1.ContactNumber);

            //named parameters
            Console.WriteLine(AddNum(15, 25));
            Console.WriteLine(AddNum(firstNum: 23, secondNum: 25));
            Console.WriteLine(AddNum(firstNum: 15, 25));
            Console.WriteLine(AddNum(15, secondNum: 25));

            //computed parameters
            Rectangle r1 = new Rectangle();
            r1.Width = 5;
            r1.Height = 5;

            Console.WriteLine("Area of r1 is" + r1.Area);



            Console.ReadKey();
        }

        //in c#,the static keyword is used to declare members
        //of a class that belong to the class itself rather than
        //to any specific instance of the class.


        //part of named parameters
        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        //part of static method
        static void MyMethod()
        {
            Console.WriteLine("My Method");
        }
    }
}
