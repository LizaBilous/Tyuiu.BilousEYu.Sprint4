using Tyuiu.BilousEYu.Sprint4.Task6.V2.Lib;
namespace Tyuiu.BilousEYu.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var colors = new string[] { "�����", "������", "�������", "�����", "�������", "������", "����������" };
            string[] res = ds.Calculate(colors);
            string[] wait = { "������", "�������", "�������", "������", "����������" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}