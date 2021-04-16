using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naruto_Hurricane_Chronicles
{
    class Program
    {
        static void Main(string[] args)
        {
            int rushAddCount = 1;
            int bossHealth = 5000;
            int bossAttack = 50;
            int health = 500;
            int kageBunshinNoJutsu = 100;
            int dotonDoryūHeki = 250; 
            int wakuseiRasengan= 1000 ;
            int wakuseiRasenganCount = 0;
            string attack;
            Console.WriteLine("Чтобы пройти дальше тебе придется убить меня");
            Console.WriteLine("Вот столько у меня жизней    " + bossHealth);
            while (bossHealth > 0)
            {
                if(health < 0)
                {
                    Console.WriteLine("Ты проиграл");
                    Console.WriteLine(bossHealth);
                }
                Console.WriteLine($"Хп противника {bossHealth}");
                Console.WriteLine($"Твои хп {health}");
                Console.WriteLine("Планетарный Рассенган (количество клонов)  " + wakuseiRasenganCount);
                health = health -bossAttack;
                Console.WriteLine("Предложенный техники Теневое клонирование, Земляная cтена, Планетарный Рассенган");
                Console.WriteLine("Введите технику");
                attack = Console.ReadLine();

                switch (attack)
                {
                    case "Теневое клонирование":
                        bossHealth = bossHealth - kageBunshinNoJutsu;
                        wakuseiRasenganCount = wakuseiRasenganCount + rushAddCount;
                        break;
                    case "Земляная стена":
                        health = health + dotonDoryūHeki;
                        break;
                    case "Планетарный Рассенган":
                        if(wakuseiRasenganCount >= 5)
                        {
                            bossHealth = bossHealth - wakuseiRasengan;
                        }
                        else
                        {
                            if(wakuseiRasenganCount < 4)
                            {
                                Console.WriteLine("Теневой клон не создан");
                            }
                        }
                        break;
                }
                if(bossHealth < 0)
                {
                    Console.WriteLine("Вы победили поздравляю");
                }
            }
            Console.ReadKey();
        }
    }
}
