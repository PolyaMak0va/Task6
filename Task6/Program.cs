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
            string longWord = String.Empty;
            foreach (string str in stringArray)
            {
                int n = Convert.ToInt32(str.Length);
                if (n > max)
                    max = n;
            }
            Console.WriteLine("Количество знаков в самом длинном слове равно: {0} ", max);
            for (int i = 0; i < stringArray.Length; i++)
            {
                string word = stringArray[i];
                while (word.Length > longWord.Length)
                {
                    longWord = word;
                }
            }
            Console.WriteLine("Cамое длинное слово в строке: {0} ", longWord);
            Console.ReadKey();
        }
    }
}
