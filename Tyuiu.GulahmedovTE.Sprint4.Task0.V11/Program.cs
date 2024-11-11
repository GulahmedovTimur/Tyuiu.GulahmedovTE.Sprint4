using Tyuiu.GulahmedovTE.Sprint4.Task0.V11.Lib;
namespace Tyuiu.GulahmedovTE.Sprint4.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            Console.WriteLine("Введенный массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение нечетных элементов массива равно " + ds.GetMultOddArrEl(numsArray));
            Console.ReadKey();
        }
    }
}