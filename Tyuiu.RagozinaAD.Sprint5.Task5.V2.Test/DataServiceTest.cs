using System.IO;
using Tyuiu.RagozinaAD.Sprint5.Task5.V2.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint5\DataSprint5\InPutDataFileTask5V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
