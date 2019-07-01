using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cmdexecute = false;

            while (!cmdexecute)
            {
                Console.WriteLine("What would you like to do? (EX. Hello World): ");
                string cmd = Console.ReadLine();

                if (cmd.ToLower().Contains("hello world"))
                {
                    Console.WriteLine();
                    HelloWorld();
                    cmdexecute = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry That does not exist. Please try again.");
                    Console.WriteLine();
                    cmdexecute = false;

                }
            }
        }

        static void HelloWorld()
        {
            Console.WriteLine("============");
            Console.WriteLine("Hello World!");
            Console.WriteLine("============");
            Console.ReadKey();
        }
    }
}
