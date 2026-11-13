using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint4.Task5.V19.Lib;

namespace Tyuiu.IzingerVA.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { -2,  1,  2, -1,  0 },
                {  3, -2, -1,  1,  2 },
                {  0, -2,  3, -1,  1 },
                { -2,  2, -1,  0,  3 },
                {  1, -1,  2, -2,  0 }
            };

            int res = ds.Calculate(matrix);
            int wait = 11;

            Assert.AreEqual(wait, res);
        }
    }
}
