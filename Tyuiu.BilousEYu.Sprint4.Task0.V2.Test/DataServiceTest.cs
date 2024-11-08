using Tyuiu.BilousEYu.Sprint4.Task0.V2.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetSumOddArrEl(numsArray);
            int numsWaitArray = 44;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}