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
            string s = "";
            foreach (string a in stringArray)
            {
                s += a.Substring(0, 1).ToLower() + a.Substring(1) + "";
            }
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            string revS = new String(ar);
            if (s == revS)
            {
                Console.WriteLine("Данное предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Данное предложение не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
