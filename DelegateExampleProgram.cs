namespace DelegatesExample
{
    public delegate int Comparison<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }


    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    //compare people[i] and people[j] using the provided comparison delegate
                    if (comparison(people[i], people[j]) > 0)
                    {
                        //swap people[i] and people[j] if they are in the wrong order.
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;

                        //people[0] Alice;
                        //people[1] bob
                        //people[3] christ
                    }
                }
            }
        }
    }

    internal class Program
    {
      
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person{Name="Alice",Age=30},
                new Person{Name="Bob",Age=25},
                new Person{Name="Denis",Age=36},
                new Person{Name="Christ",Age=35}
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name},{person.Age}");
            }
            sorter.Sort(people, CompareByName);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name},{person.Age}");
            }
            Console.ReadKey();
            

            //int[] intArray = { 1, 2, 3, 4, 5, };
            //string[] stringArray = { "one", "two", "three" };

            //PrintArray(intArray);
            //PrintArray(stringArray);
            //Console.ReadKey();
        }

        static int CompareByAge(Person x,Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x,Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
        //public static void PrintIntArray(int[] array)
        //{
        //    foreach (int item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static void PrintStringArray(string[] array)
        //{
        //    foreach (string item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //this is a generics method that accepts a generic datatype
        //public static void PrintArray<T>(T[] array)
        //{
        //    foreach (T item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

    }
}
