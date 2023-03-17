using System;
namespace counter
{ 
    class counter
    {
        static void Main(string[] arge)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;
            float answer;

            while (true)
            {
                Console.Write("Please enter the first integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());

            }
        }
    }

}

