namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;

            while (input != "NoMoreMoney") 
            { 
                double money = double.Parse(input);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");
                totalSum += money;
                input = Console.ReadLine();

                
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
