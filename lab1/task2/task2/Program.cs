using System;

namespace task2
{
    class Student
    {
        public string name; 
        public string id;
        public int year;
            public Student(string name, string id) // создаем конструктор студент 
        {
            this.name = name; // даем шаблон конструктор 
            this.id = id;
          
        }
            public Student (int year) // создаем дополнительный конструктор
        {
            this.year = year; 
        }
        public void Years() // функция для увеличения года
        {
            year++; 
        }
        public void Cout() // функция для расписывания ответа
        {
            Console.WriteLine(name + " " + id + " " + year);

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string a = Console.ReadLine(); // считываем строку 
            string[] s = a.Split(); // разделяем по пробелам
            Student kbtu = new Student(s[0], s[1]); // распределяем места
            kbtu.year = int.Parse(s[2]); //  парсим и отдельно вставляем 
            kbtu.Years(); // вызов функции
            kbtu.Cout();
        }
    }
}
