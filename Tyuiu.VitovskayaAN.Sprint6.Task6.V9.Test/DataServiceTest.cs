using Tyuiu.VitovskayaAN.Sprint6.Task6.V9.Lib;
namespace Tyuiu.VitovskayaAN.Sprint6.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFileTest()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V9.txt";

            string waitStr = "DvbkNN MPO GEzUiEPbamDblZ jKVWBlKg QzObVnRejHHXCeP";

            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(waitStr, res);
        }
    }
}