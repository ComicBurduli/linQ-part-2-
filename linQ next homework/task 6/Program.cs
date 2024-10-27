using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    public class Program
    {


        public class Employee

        {


            public string Name { get; set; }
            public string Department { get; set; }

            public int Salary { get; set; }

        }






        static void Main(string[] args)
        {


            //შევქმნათ დასაქმებულების(employees) სია, რომლებსაც დავაჯგუფებთ დეპარტამენტების მიხედვით
            //და გავფილტრავთ მხოლოდ იმ დეპარტამენტებს, სადაც საშუალო ხელფასი > 50 000.გაფილტრული
            //მონაცემების დავბეჭდოთ დეპარტამენტის დასახელების, საშუალო ხელფასის, დეპარტამენტის
            //თითოელი თანამშრომლის სახელისა და მისი ხელფასის მითითებით:



            List<Employee> employees = new List<Employee>
{

         new Employee { Name = "Alice", Department = "HR", Salary = 55000 },
         new Employee { Name = "Bob", Department = "IT", Salary = 62000 },
         new Employee { Name = "Charlie", Department = "Finance", Salary = 48000 },
         new Employee { Name = "David", Department = "IT", Salary = 54000 },
         new Employee { Name = "Eve", Department = "HR", Salary = 53000 },
         new Employee { Name = "Frank", Department = "Finance", Salary = 70000 },
         new Employee { Name = "Grace", Department = "IT", Salary = 51000 }

};

            var result = from employee in employees
                         group employee by employee.Department into departmentGroup
                         let averageSalary = departmentGroup.Average(e => e.Salary)
                         where averageSalary > 50000
                         select new
                         {
                             Department = departmentGroup.Key,
                             AverageSalary = averageSalary,
                             Employees = departmentGroup
                         };

            foreach (var dept in result)
            {
                Console.WriteLine($"Department: {dept.Department}, Average Salary: {dept.AverageSalary:C}");
                foreach (var emp in dept.Employees)
                {
                    Console.WriteLine($"  Employee: {emp.Name}, Salary: {emp.Salary:C}");
                }
            }
        }



       


    }
}
