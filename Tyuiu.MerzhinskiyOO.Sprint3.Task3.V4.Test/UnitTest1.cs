using Tyuiu.MerzhinskiyOO.Sprint3.Task3.V4.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char letter = 'j';
            string res = ds.DeleteCharInString(str, letter);
            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, res);
        }
    }
}