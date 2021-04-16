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
            int operandA = 0, operandB = 0;
            string action = "";
            int numberAction = 0;
            int expectedResult = 0;
            
            Random random = new Random(DateTime.Now.Millisecond);

            bool userWasRight = true;
            bool userWantsToContinue = true;

            while (userWantsToContinue)
            {
                if (userWasRight)
                {
                    operandA = random.Next(0, 10 + 1);
                    operandB = random.Next(0, 10 + 1);

                    numberAction = random.Next(0, 4);

                    switch (numberAction)
                    {
                        case 0:
                            action = "+";
                            expectedResult = operandA + operandB;
                            break;
                        case 1:
                            action = "-";
                            expectedResult = operandA - operandB;
                            break;
                        case 2:
                            action = "*";
                            expectedResult = operandA * operandB;
                            break;
                        case 3:
                            action = "/";
                            expectedResult = operandA / operandB;
                            break;
                        default:
                            action = "";
                            expectedResult = 0;
                            break;
                    }
                }

                Console.Write($"Сколько будет {operandA} {action} {operandB} = ");

                int userInputInt = int.Parse(Console.ReadLine());
                if (expectedResult == userInputInt)
                {
                    Console.WriteLine("Верно");
                    userWasRight = true;
                }
                else
                {
                    Console.Write("Неправильно!");
                    userWasRight = false;
                }

                Console.Write("Хотите продолжить (y/n)?: ");
                string userInput = Console.ReadLine();
                if (userInput == "n")
                {
                    userWantsToContinue = false;
                }
            }
            
            Console.ReadKey();
        }
    }
}