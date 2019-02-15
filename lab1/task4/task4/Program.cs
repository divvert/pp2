using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //парсим в интеджер и считываем строку
            for (int i = 1; i <= n; i++) // пробегаемся по элементам и увеличиваем значение на элемент
            {
                for (int j = 1; j <= i; j++)  // увеличиваем значение по строкам
                {
                    Console.Write("[*]"); // вставляем звездочки 
                }
                Console.WriteLine();
            }
        }
    }
}
