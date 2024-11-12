using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GulahmedovTE.Sprint4.Task2.V23.Lib
{
    public class DataService : ISprint4Task2V23
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (var num in array)
                if (num % 2 == 0)
                    sum += num;
            return sum;
        }
    }
}
