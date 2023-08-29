using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17777
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вітаємо в ZhylaPizza");
            Console.WriteLine("Сьогодні в мені AЖ 3 піцци");
            Console.WriteLine("1 Сирна  100 грн, 2 М'ясна 150 грн, 3 Фірмова 200");
            Console.WriteLine("Оберіть кількість  піцц");
            string quantityOfPizza = Console.ReadLine();
            int quantityPizza = int.Parse(quantityOfPizza);
           
            int cost = 0;
            
            for (int i = 1; i <= quantityPizza; i++)
            {
                Console.WriteLine("Оберіть піццу № "+ i );
                string NummberPizza = Console.ReadLine();
                int pizza = int.Parse(NummberPizza);
                switch (pizza)
                {

                    case 1:
                        cost += 100;
                        Console.WriteLine("Ви обрали сирну піццу");

                        break;
                    case 2:
                        cost += 150;
                        Console.WriteLine("Ви обрали м'ясну піццу");
                        break;

                    case 3:
                        cost += 200;
                        Console.WriteLine("Ви обрали фірмову піццу");
                        break;
                    default:
                        Console.WriteLine("Якщо  ти не можеш обрати піццу так вийди нахуй з відтси, розбійник");
                        break;
                }                
            }
            Console.WriteLine("Ви замовили піцц на сумму" +cost +"грн");
            Console.ReadKey();
        }
    }
}
