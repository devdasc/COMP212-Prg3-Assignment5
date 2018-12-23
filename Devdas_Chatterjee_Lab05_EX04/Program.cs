using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devdas_Chatterjee_Lab05_EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, Employee> employeeDictionary = new SortedDictionary<int, Employee>();
            string employeeName;
            double employeeSalary;
            // Adding Employees
            AddDictionaryItem(employeeDictionary, new Employee("Devdas", 500.00));
            AddDictionaryItem(employeeDictionary, new Employee("Micky", 790.85));
            AddDictionaryItem(employeeDictionary, new Employee("Sharif", 890.65));
            AddDictionaryItem(employeeDictionary, new Employee("Sakira", 1350.00));
            AddDictionaryItem(employeeDictionary, new Employee("Patrik", 1250.50));

            // Displaying Employees
            PrintDictionary(employeeDictionary);
            Console.WriteLine("\n-----------------------------------\n");

            // adding an Employee to the Dictionary
            Console.Write("Enter name of the employee to add: ");
            employeeName = Console.ReadLine();
            Console.Write("Enter salary of the employee to add: ");
            employeeSalary = Convert.ToDouble(Console.ReadLine());
            Employee newEmployee = new Employee(employeeName, employeeSalary);
            AddDictionaryItem(employeeDictionary, newEmployee);
            PrintDictionary(employeeDictionary);
            Console.WriteLine("\n-----------------------------------\n");

            // Search employee into dictionary
            Console.Write("Enter name of the employee to search: ");
            employeeName = Console.ReadLine();
            SearchDictionaryItem(employeeDictionary, employeeName);
            PrintDictionary(employeeDictionary);
            Console.WriteLine("\n-----------------------------------\n");

            // Remove employee from dictionary
            Console.Write("Enter name of the employee to remove: ");
            employeeName = Console.ReadLine();
            RemoveDictionaryItem(employeeDictionary, employeeName);
            PrintDictionary(employeeDictionary);
            Console.WriteLine("\n-----------------------------------\n");

            // Max salary calculation
            Console.WriteLine("Below employee has the maximum salary:");
            MaxDictionaryItem(employeeDictionary);
            Console.ReadKey();

        }

        // Adding items into dictionary
        private static void AddDictionaryItem(SortedDictionary<int, Employee> dictionary, Employee employee)
        {
            int count = dictionary.Count();

            dictionary.Add(count + 1, employee);
        }

        // Removing items from dictionary by employeeName
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> dictionary, string employeeName)
        {
            bool isFound = false;
            foreach (var key in dictionary.Keys)
            {
                Employee objEmployee = dictionary[key];
                if (objEmployee.EmployeeName.ToUpper() == employeeName.ToUpper())
                {
                    dictionary.Remove(key);
                    Console.WriteLine($"Employee {employeeName} has been removed from the dictionary");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"Employee {employeeName} was not found into the dictionary");
            }
        }

        // Displaying the dictionary
        private static void PrintDictionary(SortedDictionary<int, Employee> dictionary)
        {
            Console.WriteLine("Employee dictionary contains following information:");
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"Key:{key}, Value: {dictionary[key].ToString()}");
                Console.WriteLine();
            }
        }

        // Searching into the dictionary
        private static void SearchDictionaryItem(SortedDictionary<int, Employee> dictionary, string employeeName)
        {
            bool isFound = false;

            foreach (var key in dictionary.Keys)
            {
                Employee objEmployee = dictionary[key];
                if (objEmployee.EmployeeName.ToUpper() == employeeName.ToUpper())
                {
                    Console.WriteLine($"Employee {employeeName} found.\n");
                    Console.WriteLine($"Employee Key:{key} , Value: {dictionary[key].ToString()}");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"Employee {employeeName} does not exists in the dictionary.");
            }
        }

        // Searching the employee who has max salary
        private static void MaxDictionaryItem(SortedDictionary<int, Employee> dictionary)
        {
            double maxSalary = 0;
            string employeeName = "";
            foreach (var item in dictionary.Values)
            {
                if (item.EmployeeSalary > maxSalary)
                {
                    maxSalary = item.EmployeeSalary;
                    employeeName = item.EmployeeName;
                }
            }
            Console.WriteLine(employeeName + " has the highest salary: " + maxSalary);
        }
    }
    
}
