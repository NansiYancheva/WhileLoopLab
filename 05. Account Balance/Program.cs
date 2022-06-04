using System;
namespace While
{
    class Program
    {
        static void Main()
        {
            //INPUT
            double totalMonyeInAccount = 0;
            string currentMoneyInput = Console.ReadLine();
            //ACTIONS
            while (currentMoneyInput != "NoMoreMoney")
            {
                double currentMoneyInputAsNumber = double.Parse(currentMoneyInput);
                totalMonyeInAccount += currentMoneyInputAsNumber;
                if (currentMoneyInputAsNumber < 0)
                {
                    totalMonyeInAccount -= currentMoneyInputAsNumber;
                    Console.WriteLine("Invalid operation!");
                                        break;
                }
                else
                {
                    
                    Console.WriteLine($"Increase: {currentMoneyInputAsNumber:f2}");
                                      
                }
                currentMoneyInput = Console.ReadLine();

            }


            //OUTPUT
            Console.WriteLine($"Total: {totalMonyeInAccount:f2}");

        }
    }
}
