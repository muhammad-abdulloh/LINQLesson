using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLesson
{
    public class Queries
    {
        public static void Run()
        {
            // QS
            // select bir nechta elementlar
            /*
            IEnumerable<Employee> selectQuery = (from emp in Employee.GetEmployees()
                                                 select new Employee()
                                                 {
                                                     FirstName = emp.FirstName,
                                                     LastName = emp.LastName,
                                                     Salary = emp.Salary,
                                                 });

            foreach (Employee emp in selectQuery)
            {
                Console.WriteLine(emp.FirstName);
            }
            */

            /**
            // Method Syntax
            List<Employee> employees = Employee.GetEmployees()
                                                .Select(emp => new Employee()
                                                {
                                                    FirstName = emp.FirstName,
                                                    LastName = emp.LastName,
                                                }).ToList();

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.FirstName);
            }
            */

            /*
             //Anonymous method Query syntax
             

            var selectQuery = (from emp in Employee.GetEmployees()
                               select new
                               {
                                   PersonId = emp.Id,
                                   PersonName = emp.FirstName,
                                   PersonSurname = emp.LastName
                               }).ToList();

            foreach (var emp in selectQuery)
            {
                Console.WriteLine(emp.PersonName);
            }
            */

            /**
            // method syntax

            var selectMQuery = Employee.GetEmployees().Select(emp => new
            {
                PersonId = emp.Id,
                PersonName = emp.FirstName,
                PersonSurname = emp.LastName,
                PersonSalary = emp.Salary
            }).ToArray();

            foreach (var emp in selectMQuery)
            {
                Console.WriteLine(emp.PersonName);
            }
            */



            // Select Many

            // to'plam ichidagi to'plamga kirish 
            // ichma ich

            /** simple
            List<string> list = new List<string>() { "Muhammad Abdulloh", "Komilov" };

            IEnumerable<char> query = from str in list
                        from ch in str 
                        select ch;

            foreach (var ch in query)
            {
                Console.WriteLine(ch);
            }
            */

            // select many with to'plam
            /**
            List<string> MethodSyntax = Employee.GetEmployees().SelectMany(dasturlar => dasturlar.Programming).ToList();

            /// query syntax
            /// 
            IEnumerable<String> QuerySntax = from emp in Employee.GetEmployees()
                                      from program in emp.Programming
                                      select program;

            foreach (string s in QuerySntax)
            {
                Console.WriteLine(s);
            }
            */

            // complex method syntax 
            // bir nechta qiymatini qande olamiz deganlarga
            /*
            var MethodSyntax = Employee.GetEmployees()
                                            .SelectMany(std => std.Programming,
                                                (employee, program) => new
                                                {
                                                    EmployeeName = employee.FirstName,
                                                    ProgrammName = program
                                                }).ToList();

            foreach (var method in MethodSyntax)
            {
                Console.WriteLine(method);
            }
            */

            // Query Syntax
            /**
            var QuerySyntax = (from emp in Employee.GetEmployees()
                               from program in emp.Programming
                               select new
                               {
                                   EmployeeName = emp.FirstName,
                                   ProgrammingLanguage = program
                               }).ToList(); 

            foreach (var query in QuerySyntax)
            {
                Console.WriteLine(query.EmployeeName + " " + query.ProgrammingLanguage);
            }
            */
        
        

            //Ordering operators
            /* simple
            List<int> numbers = new List<int>() { 1, 4, 13, 213 ,132,3, 12,3,12,3,123,1, 21,1,2,1, 1,2 };
            
            var MethodSyntax = numbers.OrderBy(num => num).ToList();

            foreach ( var number in MethodSyntax )
            {
                Console.WriteLine(number);
            }
            */

            // method syntax
            /*
            var MS = Student.GetStudents().OrderBy(x => x.Branch).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item.Name);
            }
            */


            // query syntax
            /**
            var QS = from student in Student.GetStudents()
                     orderby student.Branch
                     select student;

            foreach (var item in QS)
            {
                Console.WriteLine(item.Name);
            }
            */

            // order by descending
            /**
            List<int> numbers = new List<int>() { 12, 12, 3124, 13,4,24,32, 432,4,1,324,1,4123,4,324, 32,4,32,4 };

            List<int> MS = numbers.OrderByDescending(x => x).ToList();

            /// query syntax
            List<int> QS = (from num in numbers
                     orderby num descending
                     select num).ToList();

            foreach ( var num in MS )
            {
                Console.WriteLine(num);
            }
            */

            // then by nima qiladi desak 
            // ikita bitta sort va keyin ikkinchi sort uchun
            /**
            var MS = Student.GetStudents().OrderBy(x => x.Age).ThenBy(x => x.Name).ToList();

            foreach (var m in MS)
            {
                Console.WriteLine(m.Age + " " + m.Name);
            }
            */

            // sal murakkabrog'i
            /*
            var MS = Student.GetStudents()
                .OrderBy(x => x.Branch)
                .ThenByDescending(x => x.Name)
                .ThenBy(x => x.Age)
                .ToList();

            foreach (var x in MS)
            {
                Console.WriteLine(x.Branch + " " + x.Name + " " + x.Age);
            }
            */

            // query syntax 
            /*
            var QS = (from student in Student.GetStudents()
                      orderby student.Branch ascending,
                      student.Name descending,
                      student.Age // default by ascending
                      select student
                      ).ToList();
            foreach( var x in QS)
            {
                Console.WriteLine(x.Branch + " " + x.Name + " " + x.Age);
            }
            */

            // reverce
            /**
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine("numbers");

            //IEnumerable<int> RevercedNumbers = numbers.Reverse();

            //foreach (int number in RevercedNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            IEnumerable<int> QS = (from number in numbers 
                                   select number).Reverse();

            foreach(int number in QS)
            {
                Console.WriteLine(number);
            }
            */


            // friltering operators
            //where \ Console.WriteLine()
            // ofType

        }
    }
}
