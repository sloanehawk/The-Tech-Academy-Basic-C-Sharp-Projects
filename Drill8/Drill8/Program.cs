using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, ";
            string str2 = "my name is ";
            string str3 = "Sloane";

            string text = str1 + str2 + str3;

            Console.WriteLine(text);

            str3 = str3.ToUpper();
            Console.WriteLine(str3);
            Console.ReadLine();

            //Initialize string builder
            StringBuilder sb = new StringBuilder("Hello! ");
            sb.Append("My name is Sloane. ");
            sb.Append("I am a software development student at The Tech Academy. ");
            sb.Append("\nI'm gaining experience in HTML, CSS, JavaScript, SQL, Python, and C#.");
            Console.WriteLine(sb);
            Console.ReadLine();
                
        }
    }
}
