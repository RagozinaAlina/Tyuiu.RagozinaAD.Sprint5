using Tyuiu.RagozinaAD.Sprint5.Task1.V1.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint5\Tyuiu.RagozinaAD.Sprint5.Task1.V1\bin\Debug\net8.0\OutPutDataFileTask1V1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true ;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
