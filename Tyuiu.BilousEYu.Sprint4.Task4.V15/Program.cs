using Tyuiu.BilousEYu.Sprint4.Task4.V15.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Билоус Е.Ю. | ИСТНб - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                                                      *");
            Console.WriteLine("* Задание #4                                                                                       *");
            Console.WriteLine("* Вариант #15                                                                                      *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб - 24-1                                               *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в       *");
            Console.WriteLine("* диапазоне от 2 до 6. Найдите сумму нечетных элементов массива                                    *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.Write(" Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите количество столбцов в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, colums];

            Console.WriteLine("****************************************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.Calculate(matrix);
            Console.WriteLine(" Сумма нечетных элементов массива: " + res);
            Console.ReadKey();
        }
    }
}
