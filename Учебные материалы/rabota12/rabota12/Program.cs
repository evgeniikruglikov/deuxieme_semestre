using System;
using System.IO;


namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            // чтение слов из файла rus01.txt
            string[] words = File.ReadAllLines("rus01.txt");

            // сортируем слова в алфавитном порядке, потом переворачиваем
            Array.Sort(words);
            Array.Reverse(words);

            // записываем отсортированные слова в rus02.txt
            File.WriteAllLines("rus02.txt", words);
        }
    }
}