﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GulahmedovTE.Sprint4.Task0.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
            int s = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    s *= array[i];
                }
            }
            return s;
        }
    }
}