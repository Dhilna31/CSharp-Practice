namespace ClassesApp
{
    internal class Customer
    {

        //static field to hold the next ID available.
        private static int nextId = 0;
        //readonly instance field initizalized from the constructor.
        private readonly int _id;

        //write-only properties
        private string _password;

        public string Password
        {
            set
            {
                _password = value;
            }
        }

        //Read Only Property
        public int MyProperty { get
            { return _id; }
                 }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        //Default constructor
        public Customer()
        {
            _id=nextId++;
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "None";
        }

        //custom constructor 
        //1.constructor with multiple parameters
        //default/optional parameters
        public Customer(string name, string address="NA", string contactNumber="NA")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
           
        }

        //2.constructor with one parameter
        public Customer(string name)
        {
            Name = name;
        }

        //Default parameter contactnumber

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer :Name is {Name} and Id is {_id}");
        }
        //static method
        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm driving some customer stuff");
        }

    }
}
