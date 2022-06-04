using System;
namespace While
{
    class Program
    {
        static void Main()
        {
            //INPUT
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;

            //ACTIONS
            while (input != "Stop")
            {
                int numberInput = int.Parse(input);

                if (numberInput < minNumber)
                {
                    minNumber = numberInput;

                }
                input = Console.ReadLine();
            }

            //OUTPUT
            Console.WriteLine(minNumber);

        }
    }
}
