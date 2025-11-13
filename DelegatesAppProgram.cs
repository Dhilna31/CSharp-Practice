namespace DelegatesApp
{
    internal class Program
    {
        public delegate void LogHandler(string message);

        public class Logger
        {
            public void LogToConsole(string message)
            {
                Console.WriteLine("Console Log: " +message);
            }

            public void LogToFile(string message)
            {
                Console.WriteLine("Log to File: "+message);
            }
        }

        //1.declaration
        //public delegate void Notify(string message); //from Notify onwards is what called a method signature and this declaration can be inside or outside of a class.
        //so that other classes can access the delegate.
        static void Main(string[] args)
        {

            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Log some stuff");
            //Delegates define a method signature,and any method assigned to a delegate must match this signature.

            //2.instatiation
            //Notify notifyDelegate = ShowMessage;
            //Notify notifyDelegate=new Notify(notifyDelegate);


            //3.invocation
            //notifyDelegate("Hello,Delegates!");
            Console.ReadKey();
        }

        //static void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
     
    }
}
