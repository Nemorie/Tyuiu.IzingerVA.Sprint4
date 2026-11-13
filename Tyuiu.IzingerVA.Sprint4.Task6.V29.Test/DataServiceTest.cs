using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint4.Task6.V29.Lib;

namespace Tyuiu.IzingerVA.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var seasons = new string[] { "Весна", "Лето", "Осень", "Зима" };

            int res = ds.Calculate(seasons);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
