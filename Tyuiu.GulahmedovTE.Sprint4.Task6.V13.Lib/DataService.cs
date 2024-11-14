using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GulahmedovTE.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            string[] sam = Array.FindAll(array, car => car.Length > 4);
            return sam.Length;
        }
    }
}