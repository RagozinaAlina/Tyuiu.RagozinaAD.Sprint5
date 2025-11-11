using System.IO;
using Tyuiu.RagozinaAD.Sprint5.Task2.V15.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            string path = @"C:\Usres\Алина\Desktop\soures\repos\Tyuiu.RagozinaAD.Sprint5\Tyuiu.RagozinaAD.Sprint5.Task2.V15\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
