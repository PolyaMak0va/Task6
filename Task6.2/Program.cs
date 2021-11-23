using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    class Program
    {
        // Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
        // Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
        // (пример палиндрома – «А роза упала на лапу Азора»).
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            foreach (string s in stringArray)
            {
                resultString += s.Substring(0, 1).ToLower() + s.Substring(1) + s.Trim() + " ";

            }
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
