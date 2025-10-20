using System.ComponentModel.Design;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();
            myDog.Eat();

            Cat myCat = new Cat();
            myCat.MakeSound();

            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowFields();
            derivedClass.AccessFields();

            Employee joe = new Employee("John", 36, "Sales Rep", 12345);
            joe.DisplayEmployeeInfo();


            Manager carl = new Manager("carl", 45, "Manager", 123123, 7);
            carl.DisplayManagerInfo();
            carl.BecomeOlder(5);
            carl.DisplayPersonInfo();

            Console.WriteLine(carl.ToString());
            Console.ReadKey();
        }
    }

    //base class (parent class or superclass):the class whose members are inherited.
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
        //usage of virtual keyword part of polymorphism
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }

    //child class or dervied class or subclass-the class that inherits the members of the base class.
    //for inherting we are using : and the parent class name
    class Dog : Animal
    {
        //usage of override keyword part of polymorphism
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }
    }

    //heireachial inheritance
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("cat is meowing");
        }
    }



    //breed of dog
    class Collie : Dog
    {
        public void GoingOut()
        {
            Console.WriteLine("Collie going out");
        }
    }

    class BaseClass
    {
        //access modifiers
        public int publicField;
        //avaiable to every derving or child class.
        protected int protectedField;
        private int privateField;

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, " + $"Protected: {protectedField},Private: {privateField}");
        }
    }

    //derived classes cannot access fields taht are private.
    class DerivedClass : BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            // privateField = 3;
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }


        //base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");

        }

        public void DisplayPersonInfo()
        {

            Console.WriteLine($"Name: {Name},Age: {Age}");
        }

        public int BecomeOlder(int years)
        {
            Age = Age + years;

            return Age;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }

        public int EmployeeID { get; private set; }

        //here base keyword is used as the constructor of the parent class
        public Employee(string name, int age, string jobTitle, int employeeID)
            : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee constructor called");

            Console.WriteLine("Employee (derived class) constructor called");
        }
        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job title: {JobTitle},Employee ID: {EmployeeID}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize)
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Job title: {JobTitle},Employee ID: {EmployeeID},TeamSize: {TeamSize}");
        }
    }

    public class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            Balance = amount;
            Console.WriteLine($"Deposited {amount:C}. New balance is {Balance:C}");
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount:C}. New balance is {Balance:C}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }

    public sealed class SavingAccount : Account
    {
        public SavingAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance)
        {

        }

        public override void Withdraw(decimal amount)
        {
            //savings account specific withdrawal logic.me.g.,no overdrafts allowed.
            if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("insufficent funds.Cannot withdraw from a savings account.");
            }
        }
    }
}



