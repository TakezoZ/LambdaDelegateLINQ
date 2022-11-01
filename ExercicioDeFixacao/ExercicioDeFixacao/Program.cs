using ExercicioDeFixacao.Entities;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            var salaryMoreThanBase = employees.Where(e => e.Salary >= baseSalary)
                                              .Select(e => e.Email);
            Print($"Email of people whose salary is more than {baseSalary.ToString("F2", CultureInfo.InvariantCulture)}:", salaryMoreThanBase);

            var sum = employees.Where(e => e.Name[0] == 'M')
                               .Sum(e => e.Salary);
            Console.Write($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}