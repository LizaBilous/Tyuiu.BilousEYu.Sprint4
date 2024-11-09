using Tyuiu.BilousEYu.Sprint4.Task2.V29.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = ("Спринт #4 | Выполнила: Билоус Е. Ю. | ИСТНб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу.Дан одномерный целочисленный массив на 11            *");
            Console.WriteLine("* элементов заполненный случайными числами в диапазоне от 1 до 8          *");
            Console.WriteLine("* подсчитать произведение четных элементов массива.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            
            int[] numsArray = new int[len];
            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(1, 8);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            int res = ds.Calculate(numsArray);

            Console.WriteLine("Результат произведения чётных элементов: " + ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
