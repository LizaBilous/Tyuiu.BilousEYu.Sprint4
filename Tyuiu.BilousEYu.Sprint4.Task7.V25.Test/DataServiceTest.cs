using Tyuiu.BilousEYu.Sprint4.Task7.V25.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "348561792486";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}