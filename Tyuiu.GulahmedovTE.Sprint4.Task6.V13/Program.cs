using Tyuiu.GulahmedovTE.Sprint4.Task6.V13.Lib;
namespace Tyuiu.GulahmedovTE.Sprint4.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var car = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i <= car.Length - 1; i++)
            {
                Console.WriteLine(car[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(car));
            Console.ReadKey();
        }
    }
}