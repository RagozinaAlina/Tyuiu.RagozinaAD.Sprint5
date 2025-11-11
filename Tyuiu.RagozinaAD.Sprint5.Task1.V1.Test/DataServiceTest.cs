using System.IO;
using Tyuiu.RagozinaAD.Sprint5.Task1.V1.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            string path = @"C:\Users\Алина\Desktop\soures\repos\Tyuiu.RagozinaAD.Sprint5\Tyuiu.RagozinaAD.Sprint5.Task1.V1\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
