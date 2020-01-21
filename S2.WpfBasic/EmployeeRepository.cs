using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.WpfBasic
{
    public class EmployeeRepository
    {
        private List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee {Firstname = "Brian", Lastname = "Jørgensen", HireDate = new DateTime(2017, 08, 01), YearlySalary = 10000m},
                new Employee {Firstname = "Ole", Lastname = "Bay Jensen", HireDate = new DateTime(2005, 01, 01), YearlySalary = 12000m},
            };
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
            employees.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetSingleBy(string fullname)
        {
            return employees.SingleOrDefault(e => String.Concat(e.Firstname, " ", e.Lastname) == fullname);
        }
    }
}