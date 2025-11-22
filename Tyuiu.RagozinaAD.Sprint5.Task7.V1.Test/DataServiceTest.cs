using System.IO;
using Tyuiu.RagozinaAD.Sprint5.Task7.V1.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint5\DataSprint5\InPutDataFileTask7V1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
