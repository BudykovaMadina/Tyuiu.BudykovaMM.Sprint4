using Tyuiu.BudykovaMM.Sprint4.Task5.V28.Lib;
namespace Tyuiu.BudykovaMM.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { {3, -4, -5, 1, 2 },
                                         { 0, -4, 1, 3, 2 },
                                         { -4, 3, 2, 1, 2 },
                                         { 3, 3, -6, 2, 1 },
                                        { -6, 3, -5, -4, -6 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { {3, 0, 0, 1, 2 },
                                         { 0, 0, 1, 3, 2 },
                                         { 0, 3, 2, 1, 2 },
                                         { 3, 3, 0, 2, 1 },
                                        { 0, 3, 0, 0, 0 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
