using System.IO;
using Tyuiu.RagozinaAD.Sprint5.Task6.V21.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint5\DataSprint5\InPutDataFileTask6V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            bool expect = false;
            Assert.AreEqual(expect, fileexists);
        }
    }
}

