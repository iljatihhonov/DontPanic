using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Исходная строка
            string str = "K33p C4lm";
            //Проводим замену
            str = str.Replace('3', 'e')?.Replace('4', 'a');
            //Выводим результат
            Console.WriteLine(str);
        }
    }
}