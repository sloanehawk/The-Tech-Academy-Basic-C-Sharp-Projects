using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill24
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method, create a list of at least 10 employees.
            
            List<Employee> employeeList = new List<Employee>();

            //Each employee should have a first and last name, as well as an Id. 
            //At least two employees should have the first name "Joe".
            var employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Shmoe";
            employee1.Id = 1;
            employeeList.Add(employee1);

            var employee2 = new Employee();
            employee2.FirstName = "Kim";
            employee2.LastName = "Kardashian";
            employee2.Id = 2;
            employeeList.Add(employee2);

            var employee3 = new Employee();
            employee3.FirstName = "Khloe";
            employee3.LastName = "Kardashian";
            employee3.Id = 3;
            employeeList.Add(employee3);

            var employee4 = new Employee();
            employee4.FirstName = "Kourtney";
            employee4.LastName = "Kardashian";
            employee4.Id = 4;
            employeeList.Add(employee4);

            var employee5 = new Employee();
            employee5.FirstName = "Kylie";
            employee5.LastName = "Jenner";
            employee5.Id = 5;
            employeeList.Add(employee5);

            var employee6 = new Employee();
            employee6.FirstName = "Kendall";
            employee6.LastName = "Jenner";
            employee6.Id = 6;
            employeeList.Add(employee6);

            var employee7 = new Employee();
            employee7.FirstName = "Joe";
            employee7.LastName = "Jenner";
            employee7.Id = 7;
            employeeList.Add(employee7);

            var employee8 = new Employee();
            employee8.FirstName = "Robert";
            employee8.LastName = "Kardashian";
            employee8.Id = 8;
            employeeList.Add(employee8);

            var employee9 = new Employee();
            employee9.FirstName = "Kris";
            employee9.LastName = "Jenner";
            employee9.Id = 9;
            employeeList.Add(employee9);

            var employee10 = new Employee();
            employee10.FirstName = "Caitlyn";
            employee10.LastName = "Jenner";
            employee10.Id = 10;
            employeeList.Add(employee10);

            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".

            List<Employee> joeList = new List<Employee>();

            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            //3. Do the same thing again, but this time with a lambda expression.
            List<Employee> joeListLambda = employeeList.Where(x => x.FirstName == "Joe").ToList();

            //4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> greaterThan5 = employeeList.Where(y => y.Id > 5).ToList();


            Console.ReadLine();


        }
    }
}
