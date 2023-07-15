using System.Globalization;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int qty = int.Parse(Console.ReadLine());

            List<Employee> employeesList = new List<Employee>();

            for(int i = 1; i <= qty; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeesList.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());
            Employee employee = employeesList.Find(x => x.Id == idSearch);

            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.increaseSalary(percentage);
            }

            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee item in employeesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}