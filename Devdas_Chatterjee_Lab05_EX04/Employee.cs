using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devdas_Chatterjee_Lab05_EX04
{
   public class Employee
    {
        private string employeeName;
        private double employeeSalary;

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public double EmployeeSalary
        {
            get
            {
                return employeeSalary;
            }
            set
            {
                if (value > 0)
                    employeeSalary = value;
                else
                    employeeSalary = 0.0;
            }
        }

        public Employee(string employeeName, double employeeSalary)
        {
            EmployeeName = employeeName;
            EmployeeSalary = employeeSalary;
        }

        public override string ToString()
        {
            return string.Format("Employee Name-> " + EmployeeName + ", Salary-> " + EmployeeSalary);
        }
    }
}
