using Tyuiu.BilousEYu.Sprint4.Task4.V15.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { { 4, 2, 5, 5, 3 }, 
                                         { 4, 2, 5, 2, 2 }, 
                                         { 3, 2, 4, 2, 4 }, 
                                         { 3, 6, 4, 5, 4 },
                                         { 2, 4, 6, 4, 2 } };
            int res = ds.Calculate(matrix);
            int wait = 29;

            Assert.AreEqual(wait, res);
        }
    }
}