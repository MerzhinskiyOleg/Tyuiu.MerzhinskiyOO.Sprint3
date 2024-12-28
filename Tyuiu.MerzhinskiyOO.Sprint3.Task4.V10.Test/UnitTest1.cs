using Tyuiu.MerzhinskiyOO.Sprint3.Task4.V10.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.014;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}