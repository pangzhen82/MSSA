namespace Assignment10_2
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            // -- Get all positive numbers --
            PositiveNumberProg();

            // -- Filter Employees --
            EmployeeFiltersProg();

            // -- City Names Search --
            CityNameSearchProg();

            // -- Numbers Search --
            FilterNumbersProg();

            Console.ReadKey();
        }

        static void PositiveNumberProg()
        {
            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            var result = from number in numbers
                         where number > 0
                         select number;

            Console.WriteLine("-- Get all positive numbers -- \n");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
        static void EmployeeFiltersProg()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee { Name = "Jason", Salary = 5000, Age = 31 },
                new Employee { Name = "Andrew", Salary = 4900, Age = 27 },
                new Employee { Name = "Elijah", Salary = 6200, Age = 26 },
                new Employee { Name = "Nathan", Salary = 7100, Age = 29 },
                new Employee { Name = "John", Salary = 4300, Age = 28 },
                new Employee { Name = "Amy", Salary = 5600, Age = 32 },
            };

            var filter = from emp in list
                         where emp.Salary >= 5000 && emp.Age < 30
                         select emp;
            Console.WriteLine("\n -- Filter Employees --\n");
            foreach (var emp in filter)
            {
                Console.WriteLine($"Employee name: {emp.Name}, salary: ${emp.Salary}, age: {emp.Age}");
            }
        }
        static void CityNameSearchProg()
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "ARSENALIM" };

            var result = from city in cities
                         where city.ToLower().StartsWith('a') && city.ToLower().EndsWith('m')
                         select city;
            Console.WriteLine("\n-- City Names Search --\n");
            foreach(var city in result)
            {
                Console.WriteLine(city);
            }

        }
        static void FilterNumbersProg()
        {
            int[] numbers = { 55, 200, 740, 76, 230, 482, 95 };

            var result = from number in numbers
                         where number > 80
                         select number;
            Console.WriteLine("\n-- Numbers Search --\n");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
