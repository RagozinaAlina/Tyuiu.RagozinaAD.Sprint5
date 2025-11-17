using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RagozinaAD.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace(".", ",");
            double res = Math.Round((1 / (Math.Cos(Convert.ToDouble(strX)) + Convert.ToDouble(strX))) - 4.12 * Convert.ToDouble(strX), 3);
            return res;
        }
    }
}
