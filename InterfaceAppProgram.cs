using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace InterfaceApp
{

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            //implement credit card payment logic.
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of {amount}");
            //implement credit card payment logic.
        }
    }

   // the paymentservice uses the IpaymentProcessor to process the payments.
    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }
        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

   // I indicates that it is going to be an interface.always a new word starts with capital letter.
    public interface IAnimal
    {
        //unimplemented methods
        void MakeSound();
        void Eat(string food);
    }


    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate " + food);
        }
        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("some generic animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Logs"; //use the @ sign to tell that take what is inside the c drive.
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
            message = "this is a log entry";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, "Hello world" + "\n");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            //implement the logic to log a message to a database
            Console.WriteLine($"Logging to database {message}");
        }
    }
    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }
        public void DoWork()
        {
            _logger.Log("work started");
            //do all the work!
            _logger.Log("Work done!");
        }

        /*
         Decoupling:the application class depends on the Ilogger interface rather than
        specific implementations like filelogger or databaselogger.this means you can easily
        switch the logging mechanism without changing the application class.
         */



        internal class Program
        {
            static void Main(string[] args)
            {
                string directoryPath = @"C:\Logs"; //use the @ sign to tell that take what is inside the c drive.
                string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
                string message = "this is a log entry";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                File.AppendAllText(filePath, "Hello world" + "\n");
                ////polymorphism concept
                IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
                PaymentService paymentService = new PaymentService(creditCardProcessor);
                paymentService.ProcessOrderPayment(100.00m);

                IPaymentProcessor paypalProcessor = new PayPalProcessor();
                paymentService = new PaymentService(paypalProcessor);
                paymentService.ProcessOrderPayment(200.00m);




                Dog dog = new Dog();
                dog.MakeSound();
                dog.Eat("Treat");

                //Part2 of polymorphism
                Animal myDog = new Dog();

                myDog.MakeSound();
                ILogger fileLogger = new FileLogger();
                Application app = new Application(fileLogger);
                app.DoWork();

                ILogger dbLogger = new DatabaseLogger();
                app = new Application(dbLogger);
                app.DoWork();

                Console.ReadKey();
            }
        }


    }
}
