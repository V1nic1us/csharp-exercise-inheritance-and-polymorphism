using System.Globalization;
using csharp_exercise_inheritance_and_polymorphism.Entities;

namespace csharp_exercise_inheritance_and_polymorphism
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employye #{i + 1} data");
                Console.WriteLine("Outsourced: (y/n)");
                char outSourced = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee employee;
                if (outSourced == 'y')
                {
                    Console.WriteLine("Additional change: ");
                    double additionalChange = double.Parse(Console.ReadLine());
                    employee = new OutSourcedEmployee(name, hours, valuePerHour, additionalChange);
                }
                else
                {
                    employee = new Employee(name, hours, valuePerHour);
                }
                employees.Add(employee);
            }

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}