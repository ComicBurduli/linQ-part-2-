using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = { -10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5 };
               

          foreach (double d in nums) 
                if (d > 0)
                {
                    Console.WriteLine($"კვადრატული ფესვი {nums} ებიდან არის  {Math.Sqrt(d)}");
                }
               
 

        }
    }
}
