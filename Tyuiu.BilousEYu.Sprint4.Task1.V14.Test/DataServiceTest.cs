using Tyuiu.BilousEYu.Sprint4.Task1.V14.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 };

            int res = ds.Calculate(numsArray);
            int wait = 18;

            Assert.AreEqual(wait,res);
        }
    }
}