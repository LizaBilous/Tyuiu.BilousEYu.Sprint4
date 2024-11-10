using Tyuiu.BilousEYu.Sprint4.Task3.V10.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Билоус Е.Ю. | ИСТНб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб-24-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 8. Найдите максимальный      *");
            Console.WriteLine("* элемент в третьей строке массива.                                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[,] array = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                          {5, 5, 5, 4, 6},
                                          {8, 5, 7, 4, 7},
                                          {7, 6, 7, 4, 7},
                                          {5, 8, 7, 8, 8} };
            int r = array.GetUpperBound(0) + 1;
            int c = array.Length / r;

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
