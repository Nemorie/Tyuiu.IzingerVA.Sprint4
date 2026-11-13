using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint4.Task2.V18.Lib;

namespace Tyuiu.IzingerVA.Sprint4.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 2, 3, 4, 5, 6, 7, 8, 3, 5, 7, 2, 4 };

            int res = ds.Calculate(array);
            int wait = 3072;

            Assert.AreEqual(wait, res);
        }
    }
}
