using System.IO;
using Tyuiu.RagozinaAD.Sprint5.Task3.V6.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint5\Tyuiu.RagozinaAD.Sprint5.Task3.V6\bin\Debug\net8.0\OutPutDataFileTask3V6.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
