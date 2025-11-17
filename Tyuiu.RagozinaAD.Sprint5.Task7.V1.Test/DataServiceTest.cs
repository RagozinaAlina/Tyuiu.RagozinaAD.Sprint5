using System.IO;
namespace Tyuiu.RagozinaAD.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\AppData\Local\Temp\OutPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false ;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
