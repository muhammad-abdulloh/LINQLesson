using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLesson
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 101, Name = "Muhammad Abdulloh", Gender = "Erkak", Branch = "Andijan", Age = 23 },
                new Student { Id = 102, Name = "Nurmuhammad", Gender = "Erkak", Branch = "Toshkent", Age = 20 },
                new Student { Id = 103, Name = "Sardor", Gender = "Erkak", Branch = "Samarqand", Age = 19 },
                new Student { Id = 104, Name = "Sevinch", Gender = "Ayol", Branch = "Toshkent", Age = 19 },
                new Student { Id = 105, Name = "Gulshoda", Gender = "Ayol", Branch = "Namangan", Age = 21 },

            };
        }
    } 

}
