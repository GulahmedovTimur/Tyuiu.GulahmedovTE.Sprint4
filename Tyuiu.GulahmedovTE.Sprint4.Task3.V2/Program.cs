using Tyuiu.GulahmedovTE.Sprint4.Task3.V2.Lib;
namespace Tyuiu.GulahmedovTE.Sprint4.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] { { 4, 3, 2, 8, 7 }, { 4, 6, 5, 5, 7 }, { 3, 8, 8, 3, 5 }, { 5, 7, 5, 4, 4 }, { 8, 8, 3, 7, 6 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine("Максимальный элемент = " + res);
            Console.ReadKey();


        }
    }
}