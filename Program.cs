using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test
{
    static class Program
    {
        private static readonly List<User> _users = new List<User>()
        {
            new User(1, "Petya", "Vasichkin"),
            new User(2, "Vasya", "Petrov"),
            new User(3, "Jenya", "Sachkov"),
            new User(4, "Vika", "Ivanova")
        };

        private static void Terminal()
        {
            while (true)
            {
                Console.WriteLine("\nSystem.");
                Console.WriteLine("1. Get authors list.");
                Console.WriteLine("2. Get author by identifier.");
                Console.WriteLine("3. Exit.");
                Console.Write("Your choice: ");

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
            if (_users.Count == 0)
            {
                Console.WriteLine("\nThere aren't users yet!");
                return;
            }

            Console.WriteLine("\nAuthors:");
            for (var k = 0; k < _users.Count; k++)
            {
                Console.WriteLine($"{k + 1} - {_users[k].Surname} {_users[k].Name}");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            Terminal();
        }
    }
}