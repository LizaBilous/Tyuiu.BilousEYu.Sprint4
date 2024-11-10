using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BilousEYu.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, colors => colors.Length > 5);
            return mas;
        }
    }
}
