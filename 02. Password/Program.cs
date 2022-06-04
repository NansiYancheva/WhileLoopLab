using System;
namespace While
{
    class Program
    {
        static void Main()
        {
            //INPUT
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string inputPass = Console.ReadLine();
            //ACTIONS

            while (inputPass != password)
            {
                inputPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
            //OUTPUT


        }
    }
}
