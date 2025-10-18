namespace DictionariesApp
{

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var codes = new Dictionary<string, string>
                {
                    ["NY"]="New York",
                    ["CA"]="Calfornia",
                    ["TX"]="Texas"
                };
               
                if(codes.TryGetValue("NY",out string state)){
                    Console.WriteLine(state);
                }

                foreach(var item in codes)
                {
                    Console.WriteLine($"The statecode is {item.Key} and the state name is {item.Value}");
                }

                //dictionary example
                //key-value pair
                //declaring and intializing a dictionary
                //using a complex object as the value of a dictionary
                Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

                employees.Add(1, new Employee("John Doe", 35, 100000));
                employees.Add(2, new Employee("Merlin Majo", 35, 200000));
                employees.Add(3, new Employee("Aneeta Shajan", 35, 150000));
                employees.Add(4, new Employee("Nimita Wilson", 35, 30000));
                employees.Add(5, new Employee("Dhilna David", 35, 40000));


                foreach (var item in employees)
                {
                    Console.WriteLine($"ID: {item.Key} named: {item.Value.Name}" + $"earns{item.Value.Salary}" +
                        $"and is {item.Value.Age} years old!");
                }
                Console.ReadKey();


                //adding items to a dictionary
                employee.Add(101, "Dhilna David");
                employee.Add(102, "Bob Smith");
                employee.Add(103, "rob Smith");
                employee.Add(104, "sob Smith");

                //access items in a dictionary
                string name = employee[101];
                Console.WriteLine(name);

                //updating in dictionary
                employee[102] = "Jane Smith";

                //removing item in dictionary
                employee.Remove(101);

                //handling duplicates
                if (!employee.ContainsKey(104))
                {
                    employee.Add(104, "Mike John");
                }

                bool added = employee.TryAdd(102, "Michal Brimes");

                if (added)
                {
                    Console.WriteLine("employee with the id 102 already exists");
                }

                int counter = 101;
                while (employee.ContainsKey(counter))
                {
                    counter++;
                }
                employee.Add(counter, "Jesus Christ");


                ////iterating through the dictionary
                foreach (KeyValuePair<int, string> employees in employee)
                {
                    Console.WriteLine($"ID:{employees.Key},name: {employees.Value}");
                }

                //nullable example
                int? age = null; //int? is a nullable int
                int myAge = 35;

                if (age.HasValue)
                {
                    Console.WriteLine("Age is: " + age.Value);
                    int sum = age.Value + myAge;
                }
                else
                {

                    Console.WriteLine("Age is not specified");
                }
            }
        }
    }
}





