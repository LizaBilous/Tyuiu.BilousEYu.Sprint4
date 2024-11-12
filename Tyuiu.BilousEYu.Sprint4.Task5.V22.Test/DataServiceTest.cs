using Tyuiu.BilousEYu.Sprint4.Task5.V22.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
            public void ValidCalculate()
            {
                DataService ds = new DataService();
                int[,] matrix = new int[5, 5] { { -4, 3, -7, -3, 8},
                                                { 1, 4, -2, 0, -3 },
                                                { 2, 4, 6, 4, -1 },
                                                { -5, 8, 4, -8, 5 },
                                                { 3, 6, 1, 4, 7 }};
                int res = ds.Calculate(matrix);
                int wait = 8;
                Assert.AreEqual(wait, res);
            }
    }
}