using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // конвертим количество элементов в интеджер
            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse); // конвертим строку в интеджер с помощью пробела
            int[] DobArr = new int[n * 2]; // увеличиваем размер в два раза
            int cnt = -1; // чтобы начать с нулевого элемента
            for (int i = 0; i < arr.Length; i++) // форик для считки и дублирования
            { 
                DobArr[++cnt] = arr[i];
                DobArr[++cnt] = arr[i];
            }

            foreach (int eshe in DobArr) // с помощью цикла записываем все элементы массива 
            { 
                Console.Write(eshe + " ");
                Console.ReadKey(); 
            }
        }
    }
}
