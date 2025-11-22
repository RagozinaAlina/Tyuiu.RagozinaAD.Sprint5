using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RagozinaAD.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint5\Tyuiu.RagozinaAD.Sprint5.Task0.V6\bin\Debug\net8.0\OutPutDataFileTask0V6.txt";
            double y = Math.Round(((x / (Math.Sqrt(Math.Pow(x, 2) + x)))), 3);

            File.WriteAllText(path, Convert.ToString(y));

            return path;
        }
    }
}
