using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BudykovaMM.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int m = 10000;

            for ( int i = 0; i < rows; i++ )
            {
                for ( int j = 4; j < columns; j++)
                {
                    if (array[i, j]  <  m)
                    {
                        m = array[i, j];
                    }
                }
            }
            return m;
        }
    }
}
