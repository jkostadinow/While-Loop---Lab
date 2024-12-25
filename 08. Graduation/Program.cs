namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int grade = 1;
            int fail = 0;
            double rate;
            double totalRate = 0;

            while (grade <= 12)
            {
                rate = double.Parse(Console.ReadLine());
                
                if (rate < 4)
                {
                    fail++;
                    if (fail > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        return;
                    }
                }
                else
                {
                    grade++;
                    totalRate += rate;
                }     

            }
            double averageRate = totalRate / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageRate:f2}");
        }
    }
}
