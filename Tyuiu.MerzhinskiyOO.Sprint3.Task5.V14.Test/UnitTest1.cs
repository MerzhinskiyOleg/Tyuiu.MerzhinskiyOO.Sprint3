
using Tyuiu.MerzhinskiyOO.Sprint3.Task5.V14.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = -31.275;
            Assert.AreEqual(res, wait);
        }
    }
}