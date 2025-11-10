using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RagozinaAD.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = Math.Round((double)x / (Math.Sqrt((double)x * (double)x + (double)x)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}

