﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BilousEYu.Sprint4.Task1.V14.Lib
{
    public class DataService : ISprint4Task1V14
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
