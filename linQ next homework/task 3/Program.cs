using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>
            
            {
            "To Kill a Mockingbird",
            "Pride and Prejudice",
            "1984",
            "The Great Gatsby",
            "Moby Dick"

            };




            var books = list
               .Where(title => title.StartsWith("T"))
               .Select(title => title.ToUpper());


            foreach (var title in books)
                Console.WriteLine(title);

        }
    }
}
