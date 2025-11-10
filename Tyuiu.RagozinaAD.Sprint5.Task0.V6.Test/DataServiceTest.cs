using System.IO;
using Tyuiu.RagozinaAD.Sprint5.Task0.V6.Lib;
namespace Tyuiu.RagozinaAD.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            string path = @"C:\Usres\Алина\Desktop\soures\repos\Tyuiu.RagozinaAD.Sprint5\Tyuiu.RagozinaAD.Sprint5.Task0.V6\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false ;
            Assert.AreEqual(wait, fileExists);
        }
    }
}