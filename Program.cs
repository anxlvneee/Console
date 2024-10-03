using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test
{
    internal class Program
    {
        private static void Terminal()
        {
            while (true)
            {
                Console.WriteLine("\nSystem.");
                Console.WriteLine("1. Get authors list.");
                Console.WriteLine("2. Get author by identifier.");
                Console.WriteLine("3. Exist.");
                Console.WriteLine("Your choice: ");

                var choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GetAuthors();
                        break;
                    case 2:
                        GetAuthorById();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("\nEnter correct data!");
                        break;
                }
            }
        }

        private static void GetAuthorById()
        {
            throw new NotImplementedException();
        }

        private static void GetAuthors()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
