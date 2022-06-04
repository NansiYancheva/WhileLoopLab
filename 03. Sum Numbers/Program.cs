using System;
namespace While
{
    class Program
    {
        static void Main()
        {
            //INPUT
            int initialNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            //ACTIONS
            while (sum < initialNumber)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
                            }
            //OUTPUT
            Console.WriteLine(sum);

        }
    }
}

