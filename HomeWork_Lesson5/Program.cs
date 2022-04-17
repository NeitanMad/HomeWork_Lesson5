using System;
using System.IO;
using System.Linq;

namespace HomeWork_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1,2");

            Console.Write("Введите произвольный текст: ");
            string inputtext = Console.ReadLine(); // Перременная для хранения пользовательского ввода

            File.WriteAllText(@"C:\Users\MadWorld\Desktop\text.txt" , inputtext);
            Console.WriteLine("Текст сохранен в файл text.txt ");
            File.WriteAllText(@"C:\Users\MadWorld\Desktop\startup.txt", DateTime.Now.ToString());
            Console.WriteLine("Время сохранено в файл startup.txt ");

            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите произвольный набор чисел от 0 до 255");

            string numbers = Console.ReadLine();
            var numbersRedact = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var array = new byte[numbersRedact.Length];
            for (int i = 0; i < array.Length; i++)
            {

                if (!byte.TryParse(numbersRedact[i], out var number))
                {
                    Console.WriteLine($"Incorrect number {numbersRedact[i]}");
                    return;
                }

                array[i] = number;

            }



        }
    }
}
