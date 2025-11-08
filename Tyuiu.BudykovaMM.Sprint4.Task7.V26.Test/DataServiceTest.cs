using Tyuiu.BudykovaMM.Sprint4.Task7.V26.Lib;
namespace Tyuiu.BudykovaMM.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "351268459614723";
            int res = ds.Calculate(rows, columns, str);
            int wait = 18432;
            Assert.AreEqual(wait, res);
        }
    }
}
