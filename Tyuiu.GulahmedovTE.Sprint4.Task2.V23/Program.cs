using Tyuiu.GulahmedovTE.Sprint4.Task2.V23.Lib;
namespace Tyuiu.GulahmedovTE.Sprint4.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];
            for (int i = 0; i < len; i++)
                numsArray[i] = rnd.Next(3, 9);
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            foreach (int num in numsArray)
                Console.WriteLine(num + "\t");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine($"Сумма четных чисел массива = {ds.Calculate(numsArray)}");
            Console.ReadKey();
        }
    }
}