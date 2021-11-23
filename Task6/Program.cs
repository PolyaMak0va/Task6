using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
            // Найти самое длинное слово в строке.
            Console.WriteLine("Введите предложение: ");
            string s = Console.ReadLine();
            string[] stringArray = s.Split();
            int max = 0;
            foreach (string a in stringArray)
            {
                int n = Convert.ToInt32(a.Length);
                if (n > max)
                    max = n;
            }
            Console.WriteLine("Количество знаков в самом длинном слове равно: {0} ", max);
            Console.ReadKey();
        }
    }
}
