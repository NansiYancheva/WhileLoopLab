using System;
namespace While
{
    class Program
    {
        static void Main()
        {
            //INPUT
            int initialNumber = int.Parse(Console.ReadLine());
            int currNum = 1;
            //ACTIONS
            while (currNum <= initialNumber)
            {
               Console.WriteLine(currNum);
               currNum = (currNum * 2) + 1;    
            }
            //OUTPUT
           

        }
    }
}
