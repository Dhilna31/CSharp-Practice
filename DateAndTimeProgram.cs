namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime(2018, 5, 31);
            Console.WriteLine("my birthday is {0}", dateTime);

            //write today on screen
            Console.WriteLine(DateTime.Today);

            //write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);

            Console.WriteLine("today is {0}", DateTime.Today.DayOfWeek);

            Console.WriteLine(GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in feb 2000: {0}", days);
            days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in feb 2001: {0}", days);
            days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in feb 2004: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("minute:{0}", now.Minute);

            //display the time in this structure x o'clock y minutes and z seconds
            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("write a date in this format:yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("you are {0} these much days old", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

            static DateTime GetTomorrow()
            {
                return DateTime.Today.AddDays(1);
            }

            static DateTime GetFirstDayOfYear(int year)
            {
                return new DateTime(year, 1, 1);
            }
        }
    }
}
