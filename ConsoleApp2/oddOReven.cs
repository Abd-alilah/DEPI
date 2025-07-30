namespace ConsoleApp2
{
    internal class oddOReven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check !");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            Check(num);

        }
        static void Check(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine($"The Number {number} is Even !");
            else
                Console.WriteLine($"The Number {number} is Odd !");
        }
    }
}
