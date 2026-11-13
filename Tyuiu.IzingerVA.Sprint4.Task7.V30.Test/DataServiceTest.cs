using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint4.Task7.V30.Lib;

namespace Tyuiu.IzingerVA.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "684259137159648";

            int res = ds.Calculate(n, m, value);
            int wait = 73728;

            Assert.AreEqual(wait, res);
        }
    }
}
