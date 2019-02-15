using System;

namespace task1
{
    class Program 
    {
        static public bool Prime (int arr) //вводим функцию bool для прайма для нахождения простых чисел
        {
            if (arr == 1 || arr == 0)
                return false; //если число равно 1 или 2 функция возвращает значение false
            else
            {
                for (int i=2; i<=Math.Sqrt(arr); i++) // пробегаемся по всем элементам массива начиная с 2
                {
                    if (arr % i == 0)
                        return false;  //если число делится на любое число кроме него самого функция возвращает значение false
                }
            }
            return true; // если число не подходит под предыдущие условия то оно является простым
        }
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine()); // считываем количество элементов
            string s = Console.ReadLine(); // считываем строку со значениями элементов
            string[] st = s.Split(); //разделяем элементы строки по пробелам
            int[] a = new int[n]; // создаем пустой массив чисел
            for (int i=0; i<n; i++) // пробегаемся по всем числам
            {
                a[i] = int.Parse(st[i]); // переводим значение массива в int
            }
            int cnt = 0; // создаем новое значение
            for (int i=0; i<n; i++) 
            {
                if (Prime(a[i]) == true) cnt++; // пробегаемся по всем элементам проверяя их на значение true, подсчитываем их количество
            }
            Console.WriteLine(cnt); //выводим количество простых чисел
            for (int i=0; i<n; i++)
            {
                if (Prime(a[i]) == true)
                    Console.Write(a[i] + " "); // пробегаемся по всем числам проверяя их на значение true и если оно подходит выводим в новой строке через пробел
            }
            Console.ReadKey(); // 
        }
    }
}