using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RagozinaAD.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            double y = Math.Round((double)x / (Math.Sqrt((double)x * (double)x + (double)x)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
