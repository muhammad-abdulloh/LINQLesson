using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLesson
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public List<string> Programming { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 101, FirstName = "Bahriddin", LastName = "Zuhriddinov", Salary = 30000, Programming = new List<string>(){ "C#", "C++", "TypeScript" } },
                new Employee { Id = 102, FirstName = "Zahro", LastName = "Kamolova", Salary = 20000, Programming = new List<string>(){ "C", "JavaScript", "Rust" } },
                new Employee { Id = 103, FirstName = "Rustambek", LastName = "Jurayev", Salary = 40000, Programming = new List<string>(){ "Go", "C++", "C#" } },
                new Employee { Id = 103, FirstName = "Nurmuhammad", LastName = "Farxodov", Salary = 50000, Programming = new List<string>(){ "Pascal", "CVB.NET", "PHP" } },
                new Employee { Id = 103, FirstName = "Sevinch", LastName = "Muminova", Salary = 60000, Programming = new List<string>(){ "C#", "Perl", "Assembly" } },
            };

            return employees;
        }
    }
}
