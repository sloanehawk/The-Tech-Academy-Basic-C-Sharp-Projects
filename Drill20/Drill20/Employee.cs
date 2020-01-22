using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill20
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {

            if (employee1.Id == employee2.Id)
            {
                bool employeesEqual = true;
                return employeesEqual;
            }
            else
            {
                bool employeesEqual = false;
                return employeesEqual;
            }
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                bool employeesNotEqual = true;
                return employeesNotEqual;
            }
            else
            {
                bool employeesNotEqual = false;
                return employeesNotEqual;
            }
        }
    }
}
