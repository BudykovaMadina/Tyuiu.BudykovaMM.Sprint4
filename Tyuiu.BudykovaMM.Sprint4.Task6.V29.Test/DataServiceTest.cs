using System.ComponentModel.DataAnnotations;
using Tyuiu.BudykovaMM.Sprint4.Task6.V29.Lib;
namespace Tyuiu.BudykovaMM.Sprint4.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var season = new string[] { "Весна", "Лето", "Осень", "Зима" };
            int res = ds.Calculate(season);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
