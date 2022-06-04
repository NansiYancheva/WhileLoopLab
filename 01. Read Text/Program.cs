using System;
namespace While
{
    class Program
    {
        static void Main()
        {
            //INPUT
            string text = Console.ReadLine();

            //ACTIONS
            while (text != "Stop")
            {
                               Console.WriteLine(text);
                text = Console.ReadLine();
            }

            //OUTPUT


        }
    }
}
