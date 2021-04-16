using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_DO_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int operandA, operandB;
            int summ;
            string action;
            int numberAction;

            Random random = new Random();
            operandA = random.Next(0, 10 + 1);
            operandB = random.Next(0, 10 + 1);
            numberAction = random.Next(0, 3 + 1);
            int result = operandB + operandA;
            bool isWork = true;

            while (isWork == true)
            {
                operandA = random.Next(0, 10 + 1);
                operandB = random.Next(0, 10 + 1);
                numberAction = random.Next(0, 3 + 1);
                Console.WriteLine($"1 Число {operandA} ");
                switch (action)
                {
                    case "-":
                        if (numberAction == 0)
                        {
                            action = "-";
                        }
                        break;
                    case "+":
                        if (numberAction == 1)
                        {
                            action = "-";
                        }
                        break;
                    case "*":
                        if (numberAction == 2)
                        {
                            action = "-";
                        }
                        break;
                    case "/":
                        if (numberAction == 3)
                        {
                            action = "-";
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine(action);
                Console.WriteLine($"2 Число {operandB} ");

                summ = int.Parse(Console.ReadLine());
                if (summ == result)
                {
                    Console.WriteLine("Верно");
                }
                else
                {
                    if (summ != result)
                    {
                        Console.WriteLine("Неправильно попробуй еще раз");
                    }
                }

            }
            Console.WriteLine($"Хотите продолжить ?");
            userInput = Console.ReadLine();
            if (userInput == "нет")
            {
                isWork = false;
            }
            Console.ReadKey();
        }
    }
}
