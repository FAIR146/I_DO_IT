using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string userInput;
            int operandA, operandB;
            int summ;

            Random random = new Random();
            operandA = random.Next(0, 10 + 1);
            operandB = random.Next(0, 10 + 1);
            int result = operandB + operandA;
            bool isWork = true;
            while (isWork == true)
            {
                Console.WriteLine($"Введите сумму чисел {operandA} + {operandB}");

                operandA = random.Next(0, 10 + 1);
                operandB = random.Next(0, 10 + 1);

                summ = int.Parse(Console.ReadLine());
                if (summ == result)
                {
                    Console.WriteLine("Верно");
                    score++;
                }
                else
                {
                    if (summ != result)
                    {
                        Console.WriteLine("Неправильно попробуй еще раз");
                    }
                }

                Console.WriteLine($"Хотите продолжить {score} ?");
                userInput = Console.ReadLine();
                if (userInput == "нет")
                {
                    isWork = false;
                }

            }


            Console.ReadKey();
        }
    }
}
