using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }
                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
                Console.WriteLine($"Users are {user.allUsers()}");
            }
        }
    }

}
