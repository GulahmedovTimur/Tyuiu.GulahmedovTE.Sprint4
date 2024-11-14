using Tyuiu.GulahmedovTE.Sprint4.Task7.V15.Lib;
namespace Tyuiu.GulahmedovTE.Sprint4.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 4;
            int colums = 2;
            int[,] mtrx = new int[rows, colums];
            string str = "10293847";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(rows, colums, str);
            Console.WriteLine("Количество нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}