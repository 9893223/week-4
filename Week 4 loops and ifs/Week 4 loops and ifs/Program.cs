using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_loops_and_ifs
{
    class Program
  
    {
        static void Main(string[] args)
        {
            int counter = 76;
            int finish = 46;

           

            while (counter >= finish)
            {
                if (counter % 2 != 0)
                    Console.WriteLine(counter); counter--;
            }

           
            Console.ReadLine();
        }
    }
}
