using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_loops_and_ifs
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Please enter a character or symbol i.e A,$,&:");
            char character = char.Parse(Console.ReadLine());

            Console.WriteLine("Thanks, now please enter the number of times you wish to see your symbol:");
            int user = int.Parse(Console.ReadLine());

            for (int i = 1; i <= user; i++)

            { 
                Console.WriteLine(character); 
            }

            Console.ReadLine();
        }

     }
}
