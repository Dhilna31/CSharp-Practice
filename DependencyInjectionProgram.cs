namespace DependencyInjectionApp
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("sawing wood");
        }

        public class Builder:IToolUser
        {
            private Hammer _hammer;
            private Saw _saw;
            //setter dependency injection
            //public Hammer hammer { get; set; }
            //public Saw saw { get; set; }

            //private Hammer _hammer;
            //private Saw _saw;
            //setter dependency injection
            public void BuildHouse()
            {
                _hammer.Use();
                _saw.Use();
                Console.WriteLine("House built");
            }

            public void SetHammer(Hammer hammer)
            {
                _hammer = hammer;
            }

            public void SetSaw(Saw saw)
            {
                _saw = saw;
            }

            //constructor dependency injection

            //public Builder(Hammer hammer,Saw saw)
            //{
            //    _hammer = hammer;//builder is responsible for creating its dependency
            //    _saw = saw;
            //}
            //public void BuildHouse()
            //{
            //    _hammer.Use();
            //    _saw.Use();
            //    Console.WriteLine("House Build");
            //}
            internal class Program
            {
                static void Main(string[] args)
                {
                    Hammer hammer = new Hammer();//create the dependencies outside
                    Saw saw = new Saw();

                    Builder builder = new Builder();

                    //part od setter injection
                    //builder.hammer = hammer;
                    //builder.saw = saw;

                    //interface injection
                    builder.SetHammer(hammer);
                    builder.SetSaw(saw);
                   

                    builder.BuildHouse();
                    Console.ReadLine();
                }
            }
        }
    }
}
    

