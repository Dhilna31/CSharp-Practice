namespace TemperatureEvent
{
    //using the generic Delegate EventHandler<TEventArgs>

    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        //property 
        public int Temperature { get;  }
        //constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature=temperature;
        }

    }

    public class TemperatureMointor
    {
        public EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        

       // public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
              
                if (_temperature!=value)
                {
                    _temperature = value;
                    //raise the event!!
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));

                }
            }
        }
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            //letting every subscriber know!
            TemperatureChanged?.Invoke(this,e);
        }
    }

    //subscriber

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert : temperature is {e.Temperature} sender is: {sender}");
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                TemperatureMointor monitor = new TemperatureMointor();
                TemperatureAlert alert = new TemperatureAlert();
                monitor.TemperatureChanged += alert.OnTemperatureChanged;

                monitor.Temperature = 20;
                Console.WriteLine("please enter the temperature");

                monitor.Temperature = int.Parse(Console.ReadLine());

                Console.WriteLine("Hello, World!");
            }
        }
    }

