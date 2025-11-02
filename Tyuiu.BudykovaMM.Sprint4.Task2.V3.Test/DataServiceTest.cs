using Tyuiu.BudykovaMM.Sprint4.Task2.V3.Lib;
namespace Tyuiu.BudykovaMM.Sprint4.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 5, 6, 4, 5, 5, 5, 5, 3, 4, 5, 6 };
            int res = ds.Calculate(numsArray);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
