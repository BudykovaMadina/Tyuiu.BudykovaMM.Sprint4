using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BudykovaMM.Sprint4.Task6.V29.Lib
{
    public class DataService : ISprint4Task6V29
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length > 4);
            return mas.Length;
        }
    }
}
