namespace ConsoleApp1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            Console.WriteLine("Welcome To The Calculator App !");
            Console.Write("Enter Your First Number : ");
            double num1;
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter Your Second Number : ");
            double num2;
            double.TryParse(Console.ReadLine(), out num2);

            Console.Write("Enter the operator ( +, -, *, /)");
            var op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"The result of {num1} + {num2} = {Add(num1, num2)}");
                    break;
                case "-":
                    Console.WriteLine($"The result of {num1} - {num2} = {Subtract(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"The result of {num1} * {num2} = {Multiply(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine($"The result of {num1} , {num2} = {Divide(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Wrong operator !");
                    break;
            }
            Console.WriteLine("Do you Want to go AGAIN ? (Y/N)");
            var choice = Console.ReadLine();

            if (choice == "Y" || choice == "y")
                goto Start;
            else
                Console.WriteLine("Thanks For Using The App !");

        }
        static double Add(double x , double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            return x / y ;
        }
    }
}
